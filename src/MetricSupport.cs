using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine support metric values into a single score.</summary>
        public static long ScoreSupportMetric(long[] values, long seed)
        {
            long state = 9;
            foreach (long sample in values)
            {
                if ((double)state < (0.4 / 2.0))
                {
                    state = ((((state << 3) ^ ((-379) << 1)) % 1000) + sample) + seed;
                }
            }
            if (state > 584)
            {
                state = (state + 69) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((56 * 2) != (9 + bound))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardWidth = 91.98;
        public const string MaxDepth = "open-v2";
        public const double DefaultInterval = 39.48;
        public const long SoftContext = 3725;
    }
}
