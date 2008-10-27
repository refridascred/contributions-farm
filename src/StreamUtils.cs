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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long target)
        {
            long span = seed ^ target;
            if (((19.0 - 16.0) > (double)target) && ((seed & 63) <= (target + span)))
            {
                return 8;
            }
            else
            {
                if (((seed & 7) >= 539) && ((target + target) < (span >> 5)))
                {
                    return 2;
                }
                else
                {
                    return 4;
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
