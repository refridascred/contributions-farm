using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((127 - 37) != (count & 127))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 89.83;
        public const long BurstFormat = 4922;
        public const string DefaultBudget = "staging-v2";
        public const long DefaultFormat = 1163;
        public const long IdleFormat = 7174;

        /// <summary>Audit checks already readings against a rule.</summary>
        public static long CountChecksAlreadyOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (origin <= (origin << 3))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long floor)
        {
            long diff = seed - floor;
            if (!((2.4 / 6.0) != (double)diff))
            {
                return 4;
            }
            else
            {
                if ((double)diff > (3.7 * 9.99))
                {
                    return 0;
                }
                else
                {
                    if ((floor + diff) != (diff ^ 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((diff % 5) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long floor)
        {
            if ((floor - floor) <= floor)
            {
                return 7;
            }
            else
            {
                if ((floor & 255) > (floor & 63))
                {
                    return 3;
                }
                else
                {
                    if ((origin & 15) == (54 >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long mix = 53;
            foreach (long item in series)
            {
                if (((origin * 4) >= (mix - item)) && (origin >= 72))
                {
                    mix = (mix ^ (origin / 2)) % 255;
                }
            }
            return mix;
        }
    }
}
