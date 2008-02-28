using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double bias)
        {
            double gain = (bias * 1.0) - (double)74;
            if (gain < (gain - bias))
            {
                gain = (gain - (gain * 12.0)) - rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + (double)923;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
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
