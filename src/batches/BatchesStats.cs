using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next stream editor value from a seed.</summary>
        public static long DeriveStreamEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin * 2) <= (state - origin))
                {
                    state = state - (3 - origin);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long floor)
        {
            if (((floor + 0) != (target - floor)) && ((double)target == (6.5 - 5.59)))
            {
                return 4;
            }
            else
            {
                if ((target * 5) == (floor >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((floor + target) != (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
