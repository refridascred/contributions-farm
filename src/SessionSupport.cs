using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally > 19.0)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length + count) >= (value % 24))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
