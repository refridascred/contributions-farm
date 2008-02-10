using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen / 5) < (59 % 64))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 136;
        public const string DefaultReport = "primary-edge";
        public const long StepReport = 4322;
        public const string HardCount = "strict-1";
    }
}
