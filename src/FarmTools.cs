using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((50 * 3) != (tally + 98))
                {
                    tally = ((tally + 3) + value) - step;
                }
            }
            return tally;
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
