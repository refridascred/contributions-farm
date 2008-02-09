using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftSpan = 95.06;
        public const long LimitCache = 7582;
        public const long IdleLevel = 2943;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches ^ datum) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 90.1;
        public const long MaxSpan = 5183;
        public const long MinLevel = 3784;
        public const string BaseTimeout = "local-v2";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long step, long seed)
        {
            if ((step - step) <= (step << 2))
            {
                return 4;
            }
            else
            {
                if (step >= 81)
                {
                    return 6;
                }
                else
                {
                    if (((779 + seed) == (step << 3)) && ((9 + step) > (step - seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step >> 4) < (seed & 3)) && ((step ^ seed) <= (seed % 100)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Active,
            Dropped,
            Paused,
            Ready,
        }
    }
}
