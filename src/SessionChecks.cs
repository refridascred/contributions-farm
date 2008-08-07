using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultBudget = 791;
        public const long BatchSize = 2384;
        public const double StepChecks = 6.8;
        public const long BaseChecks = 5502;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((693 << 3) > (tally & 3))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already metric readings.</summary>
        public static long TallyAlreadyMetric(long[] items)
        {
            long mark = 3;
            foreach (long datum in items)
            {
                mark = ((mark ^ (mark * 4)) % 65521) - datum;
            }
            if (mark > 0)
            {
                mark = mark - (865 / 5);
            }
            return mark;
        }
    }
}
