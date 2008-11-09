using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long limit)
        {
            if ((double)origin != (7.3 + 11.0))
            {
                return 3;
            }
            else
            {
                if (((origin << 3) >= (origin + origin)) && (800 <= (origin - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((20.0 + 9.13) == (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = mix ^ (sample + 7);
            }
            if (mix < 52)
            {
                mix = (mix ^ (mix ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
