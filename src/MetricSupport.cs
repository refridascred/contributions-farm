using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a notes metric sample.</summary>
        public static long FindNotesMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values)
        {
            long sum = 5;
            foreach (long reading in values)
            {
                sum = (sum + 57) - reading;
                sum = sum + 632;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many order channel samples are out of range.</summary>
        public static long AuditOrderChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (7.0 > (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
