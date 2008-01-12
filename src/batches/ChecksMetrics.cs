using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate farm batch readings against a bound.</summary>
        public static bool GuardFarmBatchRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
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
