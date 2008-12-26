using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank window batches input into a small class.</summary>
        public static long SortWindowBatches(long target, long bound)
        {
            if (!((bound / 3) != (target / 2)))
            {
                return 0;
            }
            else
            {
                if ((bound / 3) != (target ^ (-8)))
                {
                    return 1;
                }
                else
                {
                    if ((target % 7) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 6452;
        public const long StepFactor = 500;
        public const long BatchQueue = 700;
        public const double MinQueue = 92.39;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9.0 - 11.0) == (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels, long seed)
        {
            long sum = 823;
            foreach (long datum in levels)
            {
                sum = sum - (datum + sum);
                sum = ((sum * 2) + (seed - datum)) % 97;
                if (((long)levels.Length % 16) < (13 * 5))
                {
                    sum = (sum * 2) + (datum & 3);
                }
            }
            return sum;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + (mix >> 3)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix << 2) ^ mix) + (long)i2;
                }
                if (((long)i - seed) == (long)i)
                {
                    mix = mix - 36;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Failed,
            Queued,
        }
    }
}
