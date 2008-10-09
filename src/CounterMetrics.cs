using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every already contributi entry stays within the limit.</summary>
        public static bool CheckAlreadyContributiLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long target, long bound)
        {
            if ((double)target != (5.77 - 8.0))
            {
                return 4;
            }
            else
            {
                if (!((4 + bound) <= (target % 97)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
