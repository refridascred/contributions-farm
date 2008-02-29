using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many command commits samples are out of range.</summary>
        public static long MeasureCommandCommitsHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((double)origin > (double)hits) || (hits > ((long)series.Length << 1)))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Queued,
            Closed,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 56.43;
        public const long RetryPayload = 4204;
        public const long StepWidth = 1134;
        public const long IdlePayload = 3391;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
