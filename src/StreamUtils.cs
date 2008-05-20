using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long offset)
        {
            long anchor = 43;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (anchor << 3)) + sample) + offset;
            }
            return anchor;
        }

        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool VerifySessionBufferRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
