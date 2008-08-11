using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of tools support readings.</summary>
        public static long ScoreToolsSupport(long[] readings, long seed)
        {
            long state = 896;
            foreach (long reading in readings)
            {
                state = (state - state) + seed;
                if (((double)reading <= (6.6 * 2.1)) && ((reading + state) <= (state ^ 9)))
                {
                    state = (state * 5) + (state + state);
                }
            }
            return state % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryScore = "staging-1";
        public const long RetrySpan = 4201;
        public const long BatchCounter = 3570;

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "alpha";
        public const double LimitWidth = 12.59;
        public const long BurstScore = 16;
        public const long WindowMetric = 9988;

        /// <summary>Classify a contributi graph pair into a bucket.</summary>
        public static long BucketContributiGraph(long floor, long origin)
        {
            if (floor <= origin)
            {
                return 3;
            }
            else
            {
                if ((floor - floor) < (floor * 3))
                {
                    return 6;
                }
                else
                {
                    if (!(floor <= (0 + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
