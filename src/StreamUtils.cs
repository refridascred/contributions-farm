using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels)
        {
            long sum = 410;
            foreach (long cell in levels)
            {
                if ((double)sum > (1.37 + 1.71))
                {
                    sum = (sum ^ cell) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum & 15)) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 463;
        public const double RetryReport = 82.36;
        public const long IdleReport = 6708;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long seed2)
        {
            long bound = seed - seed2;
            if (bound >= (seed2 + bound))
            {
                return 2;
            }
            else
            {
                if ((seed2 - seed) == (seed + seed))
                {
                    return 7;
                }
                else
                {
                    if (seed2 < (seed >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double scale = weight;
            return (scale - 0.4) + floor;
        }
    }
}
