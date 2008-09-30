using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 52.79;
        public const double IdleScore = 34.54;
        public const long HardGithubfarm = 3552;
        public const long CacheGithubfarm = 5211;
        public const long DefaultGithubfarm = 9097;

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double gain = offset;
            if (gain < (double)9)
            {
                gain = (gain - (gain * 9.0)) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - offset;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double bias, double offset)
        {
            double gain = (double)5 - 1.71;
            if (gain >= offset)
            {
                gain = gain + (double)2;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order stats value against two limits.</summary>
        public static long BucketOrderStats(long limit, long seed)
        {
            if (((seed << 1) == (seed - 891)) || ((limit + limit) == (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if ((limit & 15) <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (3.1 * 18.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Ready,
            Locked,
        }
    }
}
