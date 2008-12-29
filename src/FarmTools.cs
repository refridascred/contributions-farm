using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a payload notes figure with a bias.</summary>
        public static double ScalePayloadNotes(double rate, double span)
        {
            double mean = rate;
            if (mean < (span + span))
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - rate) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((312 * 3) != (count ^ count))
                {
                    count = ((count + 1) ^ reading) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
