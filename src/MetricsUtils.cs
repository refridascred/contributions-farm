using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell - count) < cell) || (((double)cell > (1.0 + 15.0)) || ((floor >> 3) > (count & 127))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit counter token readings against a rule.</summary>
        public static long MeasureCounterTokenMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((origin - 1) != (tally - origin)) || (datum > (tally >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Idle,
            Done,
            Active,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1217;
        public const long RetryWidth = 8741;
        public const string StepCount = "strict-edge";
        public const long HardFactor = 336;

        /// <summary>Compare every pair of route cluster readings.</summary>
        public static long MatchRouteClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
