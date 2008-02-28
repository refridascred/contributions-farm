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

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels, long target)
        {
            long carry = 533;
            foreach (long datum in levels)
            {
                if (!((double)datum > (8.46 + 14.0)))
                {
                    carry = (carry << 3) ^ (carry - datum);
                }
                carry = ((carry * 4) + (datum + datum)) % 255;
                if ((426 + target) >= (926 + (-63)))
                {
                    break;
                }
            }
            return carry;
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
