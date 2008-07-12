using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine counter record values into a single score.</summary>
        public static long FoldCounterRecord(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if ((item + sum) >= (item % 2))
                {
                    sum = (sum * 3) + (item + sum);
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels, long origin)
        {
            long score = 80;
            foreach (long entry in levels)
            {
                if ((11 + (-71)) >= (score << 3))
                {
                    score = (score ^ (583 % 2)) ^ entry;
                }
                else
                {
                    score = (score ^ (origin ^ 4)) % 65521;
                    score = ((score * 3) + (origin >> 2)) % 255;
                }
                score = ((score * 3) + 838) % 97;
            }
            if (score < 69)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Pending,
            Draft,
            Queued,
            Idle,
        }
    }
}
