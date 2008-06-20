using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long sum = 1;
            foreach (long entry in samples)
            {
                if ((7 ^ sum) > (sum + sum))
                {
                    sum = sum + (entry * 3);
                }
            }
            return sum;
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
