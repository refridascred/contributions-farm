using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long seed)
        {
            if ((double)target >= (1.6 * 6.9))
            {
                return 6;
            }
            else
            {
                if ((double)target < (17.0 - 2.17))
                {
                    return 5;
                }
                else
                {
                    if ((target >= (seed + target)) || ((target + seed) != (265 >> 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed >= (target + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples, long origin)
        {
            long state = 324;
            foreach (long value in samples)
            {
                state = (((state + 136) % 101) - value) - origin;
            }
            return state;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long offset)
        {
            if ((0 - offset) == (floor + 780))
            {
                return 1;
            }
            else
            {
                if (!(offset >= (offset + floor)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSize = "stable";
        public const long HardOrder = 4311;
        public const double IdleSize = 72.94;
    }
}
