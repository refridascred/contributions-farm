using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "stable-1";
        public const string MaxScore = "latest-1";
        public const long CacheBudget = 2826;
        public const long LimitCache = 8505;
        public const double BaseRatio = 0.66;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long mix = -78;
            foreach (long item in values)
            {
                mix = ((mix - (191 + mix)) % 97) - item;
            }
            if (mix > 607)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            New,
            Queued,
            Dropped,
            Idle,
        }
    }
}
