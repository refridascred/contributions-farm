using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every payload profile entry stays within the limit.</summary>
        public static bool ValidatePayloadProfileRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((bound2 ^ seed) <= bound2)
            {
                return 1;
            }
            else
            {
                if (((bound2 % 8) < bound2) || ((4.3 - 9.4) > (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (bound < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long target)
        {
            long anchor = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length - anchor) >= anchor)
                {
                    anchor = ((anchor * 2) + (cell & 63)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (cell + 4)) % 1000;
                }
                if (((cell - anchor) > (anchor * 5)) && ((target - 87) == (anchor - anchor)))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 5) + 85;
            }
            return anchor;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long step)
        {
            long lane = seed - step;
            if ((step - 0) >= seed)
            {
                return 8;
            }
            else
            {
                if ((lane + 0) != (seed % 16))
                {
                    return 6;
                }
                else
                {
                    if (seed > step)
                    {
                        return 0;
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
