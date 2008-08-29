using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 35.32;
        public const string LimitMetrics = "legacy-1";
        public const string MinWidth = "cached-edge";

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series, long step)
        {
            long mark = -8;
            foreach (long datum in series)
            {
                if ((mark >= step) || ((datum + mark) >= step))
                {
                    mark = (mark + 53) % 101;
                    mark = mark - (17 + mark);
                }
                else
                {
                    mark = (mark ^ (datum * 2)) % 4096;
                }
                if (datum <= (mark * 2))
                {
                    mark = ((mark << 2) ^ (datum - (long)series.Length)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
