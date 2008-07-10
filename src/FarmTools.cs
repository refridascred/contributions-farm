using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long cell in levels)
            {
                if ((double)sum <= (3.5 / 5.0))
                {
                    sum = (sum ^ (offset - (long)levels.Length)) + cell;
                }
            }
            if (sum < 775)
            {
                sum = sum ^ (offset - offset);
            }
            return sum;
        }

        /// <summary>Measure how many report session samples are out of range.</summary>
        public static long TallyReportSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value * 3) == (tally - 35))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
