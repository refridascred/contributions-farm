using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double bias = (floor * 7.6) * 6.0;
            if (bias < 20.0)
            {
                bias = (bias + (double)1) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)35) - (double)(long)i;
            }
            return bias + (double)295;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= 2.26)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
