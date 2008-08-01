using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate checks layout readings against a bound.</summary>
        public static bool CheckChecksLayoutBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long offset2)
        {
            if (!((offset / 7) >= (offset2 * 4)))
            {
                return 6;
            }
            else
            {
                if (((1 / 4) == (offset ^ offset)) && (((-63) + offset) < (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 - 54) >= (offset2 ^ offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((225 / 5) == (matches + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
