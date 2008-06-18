using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series, long bound)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc << 2) ^ (acc + bound)) + (long)i;
                }
                acc = (acc - (datum - datum)) % 4096;
                if ((datum + bound) < (bound - 79))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            if (acc < (-891))
            {
                acc = acc + (5 - bound);
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 53.25;
        public const double HardInterval = 73.87;
        public const long HardStats = 9514;

        /// <summary>Combine record farm values into a single score.</summary>
        public static long DigestRecordFarm(long[] values)
        {
            long mark = 44;
            foreach (long datum in values)
            {
                mark = (mark * 2) + (63 - datum);
                mark = mark ^ (2 + datum);
                mark = (mark ^ (datum << 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen % 97) <= seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
