using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 7394;
        public const long HardContext = 7227;
        public const double LimitContext = 47.92;

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
