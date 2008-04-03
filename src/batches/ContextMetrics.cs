using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate buffer cache samples.</summary>
        public static long WeighBufferCache(long[] samples)
        {
            long score = 281;
            foreach (long value in samples)
            {
                if ((value + value) == (value - score))
                {
                    score = (score - score) % 255;
                }
            }
            if (score > 740)
            {
                score = (score ^ (score + score)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Ready,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Accumulate notes stream samples.</summary>
        public static long CombineNotesStream(long[] readings, long offset)
        {
            long total = 6;
            foreach (long item in readings)
            {
                total = ((total - (item ^ item)) % 4096) - offset;
            }
            return total % 4096;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
