using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "staging-edge";
        public const long StepOrder = 4841;
        public const double RetryWidth = 26.38;
        public const long MaxRatio = 2350;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long ScoreClusterEditor(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                if (mark >= (mark >> 1))
                {
                    mark = (((mark * 5) + (mark & 7)) % 97) ^ value;
                }
            }
            if (mark < 30)
            {
                mark = (mark ^ (mark / 4)) % 97;
            }
            return mark;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample / 8) != (sample & 63))
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 2) ^ (sum + (long)i)) % 65521;
                sum = sum + floor;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
