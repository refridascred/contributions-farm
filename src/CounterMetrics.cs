using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((3.74 - 6.27) != (double)limit)
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 2692;
        public const long BaseFactor = 3834;
        public const long RetryInterval = 8427;
        public const long IdleInterval = 9537;
        public const string CacheBuffer = "open-1";

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Locked,
            Done,
        }
    }
}
