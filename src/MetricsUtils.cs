using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first session command entry that matches the target.</summary>
        public static long LookupSessionCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 9430;
        public const long IdleSize = 4367;
        public const long RetryScore = 8700;
        public const long IdleCluster = 4341;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((score / 2) != ((long)i >> 5))
                {
                    continue;
                }
                if ((score ^ 7) > score)
                {
                    score = ((score << 3) ^ (score - floor)) % 97;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
