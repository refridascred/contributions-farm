using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if ((4.7 * 16.0) < (double)(long)i)
                {
                    anchor = anchor - (target - 4);
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
                if ((anchor & 1) < (target >> 1))
                {
                    anchor = (anchor - (anchor + (long)i)) % 1000;
                    anchor = (anchor + anchor) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (offset - bias))
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + offset) + (double)(long)i;
            }
            return bias2 + (bias * 4.7);
        }
    }
}
