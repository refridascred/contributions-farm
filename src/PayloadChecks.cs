using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long FoldChannelCounter(long[] values, long offset)
        {
            long state = 894;
            foreach (long sample in values)
            {
                state = ((state ^ (187 - offset)) % 4096) + sample;
            }
            return state % 1000;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches != (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Dropped,
            New,
        }

        /// <summary>Look up the position of a cache tools sample.</summary>
        public static long FindCacheToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 6284;
        public const long RetrySpan = 3557;
        public const long DefaultCommand = 8351;
        public const long DefaultDepth = 5740;
        public const double DefaultScore = 98.11;
    }
}
