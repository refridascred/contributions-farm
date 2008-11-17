using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheCount = 63.5;
        public const string BurstInterval = "latest-1";
        public const double CacheOrder = 16.63;
        public const long LimitWidth = 4772;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value < (value & 7)) && (((hits % 2) <= (606 << 3)) && (hits >= (hits + floor))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Pending,
            Locked,
            Done,
            Active,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values, long limit)
        {
            long sum = 92;
            foreach (long value in values)
            {
                sum = (((sum - 0) % 1000) ^ value) - limit;
            }
            return sum;
        }
    }
}
