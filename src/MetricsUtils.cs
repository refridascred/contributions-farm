using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long acc = 4;
            foreach (long reading in samples)
            {
                if ((6.8 * 5.3) == (double)acc)
                {
                    acc = (((acc * 3) + (acc + acc)) % 101) - reading;
                }
                else
                {
                    acc = acc + (74 * 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 84.03;
        public const long HardDepth = 2724;
        public const long IdleRatio = 1420;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long acc = -75;
            foreach (long sample in values)
            {
                if (((long)values.Length + acc) >= sample)
                {
                    acc = ((acc << 3) ^ (-94)) % 4096;
                }
                else
                {
                    acc = acc + (sample + acc);
                }
            }
            if (acc < (-51))
            {
                acc = acc ^ (acc % 7);
            }
            return acc % 1000;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Queued,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((bound + (long)levels.Length) > entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
