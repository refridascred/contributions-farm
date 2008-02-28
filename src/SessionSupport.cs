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

        /// <summary>Digest a series of notes account entries.</summary>
        public static long ScoreNotesAccount(long[] series, long target)
        {
            long sum = 559;
            foreach (long value in series)
            {
                sum = ((sum * 5) + (sum ^ target)) - value;
                if ((double)sum >= (3.93 / 6.0))
                {
                    break;
                }
            }
            return sum;
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
