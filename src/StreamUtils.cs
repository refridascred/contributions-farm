using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1781;
        public const long CacheCounter = 2616;
        public const long DefaultCounter = 6939;
        public const double BurstCount = 89.93;
        public const double BatchCounter = 36.83;

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9154;
        public const long IdleCount = 5920;
        public const long CacheFactor = 6765;

        /// <summary>Rank context support input into a small class.</summary>
        public static long BucketContextSupport(long step, long floor)
        {
            long delta = step ^ floor;
            if (((-889) * 5) == (step & 63))
            {
                return 8;
            }
            else
            {
                if (delta > (floor >> 1))
                {
                    return 5;
                }
                else
                {
                    if (((delta >> 3) != (floor ^ 12)) && (delta >= (step * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Pending,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
