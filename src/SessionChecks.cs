using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "strict-v2";
        public const double BatchContext = 3.24;
        public const long SoftContext = 708;
        public const string BaseInterval = "legacy-v2";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(19.0 < (double)seen))
                {
                    seen = ((seen + 1) - reading) - seed;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long floor, long origin)
        {
            long next = floor - origin;
            if ((next * 5) > (next << 1))
            {
                return 1;
            }
            else
            {
                if (((8.7 * 8.14) < (double)floor) && ((4.56 * 9.7) <= (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((next - origin) >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
