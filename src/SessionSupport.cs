using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long target)
        {
            if ((target & 31) < (step - step))
            {
                return 7;
            }
            else
            {
                if ((target < (target / 3)) || ((step ^ step) >= (step << 3)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell - count) > (cell + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 623;
        public const double MinFarm = 50.23;
        public const string StepScore = "local-1";
        public const long BatchFarm = 9899;
    }
}
