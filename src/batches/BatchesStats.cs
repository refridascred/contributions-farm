using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the buffer batch series from a seed.</summary>
        public static long StepBufferBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor - (876 ^ 54);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long limit, long seed)
        {
            if ((limit + seed) == (75 + (-51)))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (double)447)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit == (3.0 + 6.16))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - seed) > (seed ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if (!((origin & 255) < (bound + origin)))
            {
                return 5;
            }
            else
            {
                if (7 > (origin / 3))
                {
                    return 2;
                }
                else
                {
                    if (((origin2 + origin2) != (bound + bound)) || ((origin2 - origin2) <= (6 - 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series, long origin)
        {
            long state = 23;
            foreach (long item in series)
            {
                if (((double)state > 3.8) && ((double)item == (1.12 - 1.97)))
                {
                    state = ((state << 3) ^ (state ^ item)) % 97;
                }
                state = (state ^ item) % 101;
                if (((601 - item) < state) || ((state << 2) < origin))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = (state + (origin + state)) % 97;
            }
            return state;
        }
    }
}
