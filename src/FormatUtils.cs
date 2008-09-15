using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long result = 923;
            foreach (long sample in samples)
            {
                result = ((result - ((long)samples.Length + result)) % 1000) - sample;
                if ((double)result != (19.0 - 1.87))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Dropped,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Count the batch entry entries that pass the check.</summary>
        public static long TallyBatchEntryGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)step >= 3.11)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSize = 2551;
        public const double RetryWidth = 75.6;
        public const string MinLayout = "latest-edge";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
