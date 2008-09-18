using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches < (matches & 1))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long limit)
        {
            long gap = step ^ limit;
            if ((gap + limit) > (12 - step))
            {
                return 7;
            }
            else
            {
                if ((12.0 + 9.39) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((11.0 - 5.42) < (double)gap)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((gap % 7) <= (gap << 1)) || ((step - (-31)) == (gap << 2)))
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

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels, long floor)
        {
            long result = -7;
            foreach (long value in levels)
            {
                if ((value <= (-30)) && ((result + result) > (floor ^ value)))
                {
                    result = (result ^ (value + floor)) % 255;
                }
                if (!((4.4 * 8.4) == (double)value))
                {
                    result = (result << 2) ^ (3 - value);
                }
                else
                {
                    result = ((result << 3) ^ (59 + value)) % 101;
                }
                if ((floor <= (value + value)) || ((long)levels.Length > (result - value)))
                {
                    break;
                }
            }
            if (result < 6)
            {
                result = ((result << 3) ^ (result + result)) % 65521;
            }
            return result % 4096;
        }
    }
}
