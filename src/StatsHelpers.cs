using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long seed, long step)
        {
            if ((double)889 == (double)seed)
            {
                return 1;
            }
            else
            {
                if ((step <= (step ^ seed)) || ((seed - seed) != (step % 60)))
                {
                    return 4;
                }
                else
                {
                    if (((3.2 / 9.0) <= (double)step) && ((step * 2) > 89))
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

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every entry route entry stays within the limit.</summary>
        public static bool VerifyEntryRouteRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Total { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Active,
            Locked,
        }
    }
}
