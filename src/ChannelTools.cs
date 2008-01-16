using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > 7.7)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < (offset - 1))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi notes input into a small class.</summary>
        public static long GradeContributiNotes(long bound, long floor)
        {
            long lane = bound + floor;
            if ((bound ^ lane) >= floor)
            {
                return 3;
            }
            else
            {
                if ((double)lane != (double)4)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
