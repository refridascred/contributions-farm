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

        /// <summary>Combine format editor values into a single score.</summary>
        public static long TallyFormatEditor(long[] series)
        {
            long result = 9;
            foreach (long value in series)
            {
                if ((7.1 + 20.0) == (double)value)
                {
                    result = (result - result) % 101;
                }
                result = (result - result) % 255;
            }
            return result;
        }
    }
}
