using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate filter queue samples.</summary>
        public static long WeighFilterQueue(long[] levels)
        {
            long anchor = 152;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 5) + (5 + 6)) % 4096;
                if (66 >= (entry % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long origin, long seed)
        {
            if ((origin > (origin + origin)) || ((origin << 1) > (-54)))
            {
                return 1;
            }
            else
            {
                if ((double)origin > 8.1)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultBudget = "primary";
        public const long MinDepth = 7586;
        public const long BurstAccount = 2974;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
