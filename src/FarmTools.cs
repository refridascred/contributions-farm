using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value & 255) > (tally + 38))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally + tally) < (item % 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long total = 447;
            foreach (long entry in readings)
            {
                if ((51 + total) >= (entry - total))
                {
                    total = ((total * 5) + (long)readings.Length) % 1000;
                }
                else
                {
                    total = ((total * 4) + (entry - entry)) % 255;
                }
            }
            if (total > 14)
            {
                total = (total + (total ^ total)) % 1000;
            }
            return total;
        }
    }
}
