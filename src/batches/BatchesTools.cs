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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings, long seed)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) ^ value;
            }
            if (anchor < (-3))
            {
                anchor = (anchor - (seed + seed)) % 255;
            }
            return anchor;
        }
    }
}
