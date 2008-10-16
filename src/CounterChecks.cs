using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double scale = bias;
            if (scale >= (span / 8.0))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (scale / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (span / 2.0)) + (double)(long)i;
            }
            return scale - (scale + span);
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a report metric reading by value.</summary>
        public static long LocateReportMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
