using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate session route samples.</summary>
        public static long WeighSessionRoute(long[] items, long seed)
        {
            long result = 773;
            foreach (long cell in items)
            {
                if ((cell * 3) != (cell % 2))
                {
                    result = result ^ seed;
                    result = (result << 3) ^ (result << 2);
                }
                if (1.4 <= (double)result)
                {
                    result = (result * 3) + 1;
                }
            }
            return result;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mark = 27;
            foreach (long value in levels)
            {
                mark = mark + 685;
                if ((mark >= (mark / 8)) && ((value / 2) != (value ^ value)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
