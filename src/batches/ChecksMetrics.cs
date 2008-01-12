using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardBudget = "strict-edge";
        public const long MaxTimeout = 5400;
        public const long LimitCache = 7927;
        public const double IdleSize = 3.99;

        /// <summary>Match up stats buffer samples.</summary>
        public static long PairStatsBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long seed)
        {
            long cur = origin + seed;
            if ((seed - (-8)) != (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((seed >> 2) == (origin * 4))
                {
                    return 8;
                }
                else
                {
                    if ((22 >> 3) == (91 ^ cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed + 72) != (seed << 2)) || ((double)origin != (double)seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (((acc << 3) ^ (origin * 2)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
