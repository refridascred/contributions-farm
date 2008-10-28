using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            New,
            Retry,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftCount = 31.85;
        public const long DefaultCount = 2441;
        public const string MinToken = "strict-1";

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

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long bound, long bound2)
        {
            long span = bound + bound2;
            if (!(bound < (span - span)))
            {
                return 4;
            }
            else
            {
                if ((bound2 - bound) > bound2)
                {
                    return 5;
                }
                else
                {
                    if ((7.2 + 1.7) > (double)bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6 % 10) <= (span + bound))
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
