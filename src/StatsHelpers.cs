using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank batches support input into a small class.</summary>
        public static long ClassifyBatchesSupport(long bound, long limit)
        {
            if ((limit > (bound + bound)) && ((double)bound >= (1.7 - 4.2)))
            {
                return 1;
            }
            else
            {
                if (limit < bound)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 > (double)bound) && (bound <= (bound / 8)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Done,
            Failed,
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
