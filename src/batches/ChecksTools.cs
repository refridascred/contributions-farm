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

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

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

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Dropped,
            Stale,
        }
    }
}
