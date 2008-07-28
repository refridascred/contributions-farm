using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double weight, double span)
        {
            double ratio = span;
            if (ratio < (double)94)
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long origin, long origin2)
        {
            if ((double)origin >= 6.22)
            {
                return 4;
            }
            else
            {
                if (((211 / 8) >= origin2) || ((origin2 >> 5) != (origin & 1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin + origin) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin + origin2) == (origin - origin)) || (origin2 < (2 + origin)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleSpan = 43.06;
        public const string StepLevel = "legacy-edge";
        public const long CacheStats = 2348;
        public const long HardStats = 8908;
    }
}
