using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (13.0 <= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Grade a entry layout value against two limits.</summary>
        public static long ClassifyEntryLayout(long bound, long target)
        {
            if (target >= (bound / 3))
            {
                return 7;
            }
            else
            {
                if (!((21 & 255) < (target - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((target + target) < (-35))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first format schema entry that matches the target.</summary>
        public static long SeekFormatSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
