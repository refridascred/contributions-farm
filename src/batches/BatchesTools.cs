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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long offset, long bound)
        {
            if ((bound - bound) != (offset & 7))
            {
                return 2;
            }
            else
            {
                if (!((offset / 2) == (offset / 3)))
                {
                    return 3;
                }
                else
                {
                    if (!((636 % 16) <= (offset - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound == (8.99 * 1.05))
                        {
                            return 6;
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
}
