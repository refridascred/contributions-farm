using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long TallyWindowBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
