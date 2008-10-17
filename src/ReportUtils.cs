using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((39 / 4) < (tally % 7))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up editor window samples.</summary>
        public static long PairEditorWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor tools samples are out of range.</summary>
        public static long MeasureEditorToolsMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count > (cell >> 2)) && ((count + cell) <= (count + bound)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank checks notes input into a small class.</summary>
        public static long SortChecksNotes(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (((cur % 8) < (floor + cur)) && (floor <= (354 + 9)))
            {
                return 0;
            }
            else
            {
                if ((double)(-3) > (double)cur)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
