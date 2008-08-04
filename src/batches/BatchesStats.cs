using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally + tally) <= (datum >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long floor)
        {
            long delta = target + floor;
            if ((double)target >= (double)floor)
            {
                return 5;
            }
            else
            {
                if (!((double)delta >= (double)162))
                {
                    return 8;
                }
                else
                {
                    if ((floor / 2) != (delta & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 8797;
        public const long MaxEntry = 6184;
        public const double HardFactor = 5.47;
        public const double DefaultCount = 62.51;
        public const string LimitInterval = "staging-1";

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long state = 57;
            foreach (long item in data)
            {
                if (state >= item)
                {
                    state = state - (28 + item);
                }
            }
            return state;
        }
    }
}
