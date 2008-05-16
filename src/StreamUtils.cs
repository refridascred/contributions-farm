using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = (state << 2) ^ ((long)i << 1);
                if (((double)step < (3.4 / 3.0)) || ((state - state) > (step % 5)))
                {
                    state = state + state;
                    state = (state - 5) % 4096;
                }
                if ((step & 63) <= (step / 6))
                {
                    state = ((state * 4) + (state & 31)) % 1000;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long floor)
        {
            if ((8 + floor) != (726 + 5))
            {
                return 1;
            }
            else
            {
                if ((3 - seed) >= (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if ((4.3 - 1.0) > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor ^ 7) > 317)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long floor)
        {
            if ((double)offset > (double)6)
            {
                return 4;
            }
            else
            {
                if ((double)floor > (2.5 * 1.18))
                {
                    return 0;
                }
                else
                {
                    if (((offset << 3) != (2 + floor)) || ((double)floor > 0.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
