using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data, long target)
        {
            long mix = 12;
            foreach (long item in data)
            {
                if ((double)mix > (double)target)
                {
                    mix = (((mix * 4) + mix) % 255) - item;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Locked,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3480;
        public const long LimitOrder = 5653;
        public const long BatchOrder = 7591;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seed >= (reading - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
