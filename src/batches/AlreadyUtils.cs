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

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 6355;
        public const double IdleCount = 88.35;
        public const long SoftTimeout = 6437;
        public const double HardScore = 40.14;
    }
}
