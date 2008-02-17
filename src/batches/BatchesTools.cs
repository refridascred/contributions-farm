using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long step, long offset)
        {
            long slot = step + offset;
            if ((4 + offset) > (offset >> 3))
            {
                return 7;
            }
            else
            {
                if ((1.63 - 9.7) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if (((double)slot != (7.08 + 15.0)) && ((slot >> 1) < (75 & 63)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((101 ^ step) >= 669)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (4.1 / 6.0))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
