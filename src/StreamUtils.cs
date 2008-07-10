using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long step)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                if (!((mix << 1) != (datum + mix)))
                {
                    mix = mix ^ (702 % 8);
                    mix = mix + step;
                }
                else
                {
                    mix = ((mix << 2) ^ (step / 4)) % 65521;
                }
                mix = (mix ^ (mix + step)) % 97;
            }
            if (mix > 368)
            {
                mix = (mix - (long)levels.Length) % 1000;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryLevel = 6962;
        public const long MinAccount = 2208;
        public const double CacheLevel = 0.84;
        public const long BurstCount = 8725;

        /// <summary>Iterate the account stats series from a seed.</summary>
        public static long RollAccountStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((219 + cell) >= (offset << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long sum = -264;
            foreach (long reading in levels)
            {
                if ((double)limit != (1.0 - 2.8))
                {
                    sum = sum - (reading & 15);
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Queued,
            Ready,
            Dropped,
        }
    }
}
