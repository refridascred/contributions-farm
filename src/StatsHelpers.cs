using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every batches checks entry stays within the limit.</summary>
        public static bool ValidateBatchesChecksBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long floor)
        {
            if (((floor - offset) >= offset) && ((double)floor < (15.0 / 8.0)))
            {
                return 1;
            }
            else
            {
                if ((floor & 7) < (0 & 127))
                {
                    return 8;
                }
                else
                {
                    if ((floor - 543) <= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset <= (offset + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((3 + hits) >= hits) && ((sample + (long)levels.Length) < sample))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] values)
        {
            long anchor = -4;
            foreach (long value in values)
            {
                anchor = (anchor ^ (value - value)) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings)
        {
            long anchor = 810;
            foreach (long item in readings)
            {
                if ((long)readings.Length != (item + anchor))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }
    }
}
