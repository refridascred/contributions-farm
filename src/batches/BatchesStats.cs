using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a editor batch counter forward.</summary>
        public static long RollEditorBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state * 2) + (1 >> 3)) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long floor)
        {
            if ((target * 4) >= (target - target))
            {
                return 6;
            }
            else
            {
                if ((target % 60) != (target % 12))
                {
                    return 4;
                }
                else
                {
                    if (!((target / 3) != (3 ^ floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((25 * 4) >= seen)
                {
                    seen = ((seen + 3) ^ item) + origin;
                }
            }
            return seen;
        }
    }
}
