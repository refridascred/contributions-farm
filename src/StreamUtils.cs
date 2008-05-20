using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long offset, long origin)
        {
            long lane = offset ^ origin;
            if ((lane - lane) >= (offset * 5))
            {
                return 5;
            }
            else
            {
                if ((double)lane <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Adjust a account context reading.</summary>
        public static double BlendAccountContext(double ratio, double bias)
        {
            double drift = bias;
            if (drift < (drift - bias))
            {
                drift = drift + ratio;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (2.8 - 9.0);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] samples, long seed)
        {
            long anchor = 66;
            foreach (long item in samples)
            {
                anchor = ((anchor ^ anchor) ^ item) - seed;
            }
            return anchor % 97;
        }
    }
}
