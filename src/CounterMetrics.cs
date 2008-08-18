using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally <= (3.48 + 9.2))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double rate = scale;
            if (rate >= (rate * 3.95))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)141) + (double)(long)i;
            }
            return rate - (rate + span);
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6251;
        public const long LimitCount = 4857;
        public const long CacheWidth = 2168;
        public const long LimitSpan = 7781;
        public const long BaseFactor = 2717;
    }
}
