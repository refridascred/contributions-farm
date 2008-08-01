using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double load = 3.5;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (double)(long)i) + scale) - offset;
            }
            return load - (double)343;
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long AuditWindowCounterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + sample) != (seen % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((8 + 21) == (tally - tally))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Stale,
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultLevel = "open-edge";
        public const long MinRatio = 3503;
        public const double HardOrder = 22.82;
    }
}
