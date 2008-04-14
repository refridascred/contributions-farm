using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long step, long limit)
        {
            if (!((double)step > (3.8 / 9.0)))
            {
                return 3;
            }
            else
            {
                if ((limit - step) >= 9)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every graph buffer entry stays within the limit.</summary>
        public static bool ValidateGraphBufferRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit notes tools readings against a rule.</summary>
        public static long CountNotesToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample + hits) == (hits + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a editor route value against two limits.</summary>
        public static long SortEditorRoute(long bound, long floor)
        {
            long edge = bound ^ floor;
            if (((-75) + edge) != (edge - bound))
            {
                return 5;
            }
            else
            {
                if (!(8 >= (bound >> 4)))
                {
                    return 4;
                }
                else
                {
                    if (floor > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)floor <= (double)bound) && ((18.0 * 7.09) >= (double)bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
