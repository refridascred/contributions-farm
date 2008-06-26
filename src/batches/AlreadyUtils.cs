using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long origin)
        {
            long offset = bound - origin;
            if ((461 - offset) <= (offset & 63))
            {
                return 2;
            }
            else
            {
                if (!(offset < (offset * 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin != (8.11 + 18.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin >> 4) <= bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a profile window figure with a bias.</summary>
        public static double SmoothProfileWindow(double weight, double floor)
        {
            double load = (double)(70 + 524);
            if (load >= (load + floor))
            {
                load = load + floor;
            }
            else
            {
                load = load - (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)(-580)) + (double)(long)i;
            }
            return load - (weight * 20.0);
        }

        /// <summary>Look up the position of a token metric sample.</summary>
        public static long FindTokenMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Ready,
            Failed,
            Paused,
            Pending,
        }
    }
}
