using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next support report value from a seed.</summary>
        public static long RollSupportReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two tools counter measurements.</summary>
        public static double AdjustToolsCounter(double weight, double span)
        {
            double rate = (double)(166 >> 3);
            if (rate > (double)0)
            {
                rate = (rate - weight) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Accumulate session cache samples.</summary>
        public static long DigestSessionCache(long[] items)
        {
            long anchor = 828;
            foreach (long item in items)
            {
                anchor = (((anchor * 4) + (anchor + 9)) % 1000) - item;
                if ((double)anchor > (13.0 / 4.0))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first contributi metrics entry that matches the target.</summary>
        public static long FindContributiMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
