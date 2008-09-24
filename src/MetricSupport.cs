using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading & 3) <= reading)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 583;
        public const long RetryFactor = 6479;
        public const long BaseFormat = 8327;
        public const double HardBudget = 25.46;
        public const string SoftTimeout = "local-edge";

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long seed)
        {
            long acc = 550;
            foreach (long cell in readings)
            {
                acc = ((acc + (acc >> 3)) ^ cell) - seed;
            }
            if (acc > 8)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }
    }
}
