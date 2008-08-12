using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a stream metric counter forward.</summary>
        public static long IterateStreamMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor + (step + step);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor ^ ((long)i / 9)) % 101) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 1060;
        public const double LimitRoute = 0.98;
        public const double BaseRoute = 52.55;

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - floor) < (tally << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
