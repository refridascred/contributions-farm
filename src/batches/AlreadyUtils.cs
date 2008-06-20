using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((6.0 + 9.0) >= (double)origin))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long mix = 79;
            foreach (long value in series)
            {
                if (((long)series.Length - value) < (value + value))
                {
                    mix = mix - (value & 3);
                }
                mix = (mix - (value % 7)) % 4096;
            }
            return mix;
        }

        /// <summary>Fold a list of queue filter readings.</summary>
        public static long FoldQueueFilter(long[] levels, long limit)
        {
            long sum = 2;
            foreach (long entry in levels)
            {
                if ((limit + sum) != (limit - entry))
                {
                    sum = (sum ^ (entry >> 2)) % 4096;
                }
                else
                {
                    sum = (sum - (entry + 5)) % 4096;
                }
            }
            if (sum < 5)
            {
                sum = (sum - (sum / 6)) % 101;
            }
            return sum;
        }
    }
}
