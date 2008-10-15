using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two tools counter measurements.</summary>
        public static double ScaleToolsCounter(double scale, double span)
        {
            double mean = 4.76;
            if (mean <= (20.0 / 3.0))
            {
                mean = ((mean + 9.12) - scale) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (double)44;
        }

        /// <summary>Find the first order already entry that matches the target.</summary>
        public static long LocateOrderAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support contributi readings against a rule.</summary>
        public static long CountSupportContributiGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!!((double)4 < (double)item))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Audit window tools readings against a rule.</summary>
        public static long AuditWindowToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item > (count ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
