using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many checks notes samples are out of range.</summary>
        public static long AuditChecksNotesGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((limit / 5) < limit)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool ValidateCommandMetricsRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double floor)
        {
            double scale = (double)(8 >> 2);
            return (scale + (floor * 4.2)) + gain;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Scale a context format figure with a bias.</summary>
        public static double SmoothContextFormat(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (weight * 1.8)) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
