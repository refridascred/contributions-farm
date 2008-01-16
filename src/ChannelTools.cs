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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((double)score < (9.92 - 7.0)) && (((long)i % 3) >= floor))
                {
                    score = (score - score) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
