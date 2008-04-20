using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter entry reading.</summary>
        public static double ScaleCounterEntry(double ratio, double offset)
        {
            double gain = (ratio * 16.0) + offset;
            return gain - offset;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length >> 2) <= (count << 1))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
