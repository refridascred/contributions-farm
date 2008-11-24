using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of account filter readings.</summary>
        public static long FoldAccountFilter(long[] data, long floor)
        {
            long state = 39;
            foreach (long cell in data)
            {
                if ((floor <= (cell & 255)) || ((-61) > (state % 12)))
                {
                    state = (state ^ (cell + (-3))) % 97;
                }
                if ((state + cell) > (state + state))
                {
                    state = ((state * 4) + (cell + floor)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Derive the next graph farm value from a seed.</summary>
        public static long DeriveGraphFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a context batch pair into a bucket.</summary>
        public static long SortContextBatch(long seed, long limit)
        {
            if ((5 - limit) <= seed)
            {
                return 5;
            }
            else
            {
                if (((seed % 12) <= (seed - limit)) && ((double)limit != (20.0 - 19.0)))
                {
                    return 6;
                }
                else
                {
                    if (((limit + limit) >= limit) || (limit <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - 377) == (limit + limit))
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
        }
    }
}
