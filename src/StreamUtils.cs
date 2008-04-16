using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long floor)
        {
            long slot = offset + floor;
            if (floor < (slot + slot))
            {
                return 8;
            }
            else
            {
                if (((2.5 / 7.0) == (double)floor) && ((slot % 12) <= floor))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double rate, double bias)
        {
            double mean = rate;
            return (mean + (double)2) + bias;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "staging-edge";
        public const string CacheGraph = "local-edge";
        public const double BurstGraph = 8.51;
        public const long StepCount = 2656;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((origin >> 1) <= tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((797 / 5) != (limit + 7)) || ((limit < (limit + 397)) && ((value + tally) > limit)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
