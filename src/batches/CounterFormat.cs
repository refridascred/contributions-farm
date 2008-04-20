using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 92.84;
        public const long WindowInterval = 1376;
        public const double HardCount = 38.99;
        public const long StepTimeout = 4605;
        public const long MaxWindow = 5231;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) > matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics cluster entries.</summary>
        public static long ScoreMetricsCluster(long[] data)
        {
            long state = 79;
            foreach (long datum in data)
            {
                state = (state + ((-71) * 4)) % 1000;
                if ((datum >> 3) < datum)
                {
                    state = (state ^ (datum * 2)) % 1000;
                }
                else
                {
                    state = (state ^ (4 % 16)) % 255;
                }
            }
            return state;
        }
    }
}
