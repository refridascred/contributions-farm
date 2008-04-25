using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Label { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleDepth = 3713;
        public const double LimitEditor = 89.24;
        public const double WindowScore = 64.59;
    }
}
