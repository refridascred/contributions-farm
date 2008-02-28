using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count == (12.0 / 7.0))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the stats queue entries that pass the check.</summary>
        public static long MeasureStatsQueueMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample % 16) >= ((long)readings.Length + 1))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
