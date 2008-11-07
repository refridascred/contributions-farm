using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i % 2) > 165)
                {
                    continue;
                }
                else
                {
                    acc = (acc + (origin << 3)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long CountFarmAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value < (matches & 127)) || (((-70) + value) >= (matches / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long sum = 93;
            foreach (long sample in series)
            {
                if ((sample + 780) != (sample + 644))
                {
                    sum = ((sum << 2) ^ sum) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Draft,
            Synced,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (target > (target % 10))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
