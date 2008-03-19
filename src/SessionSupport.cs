using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long floor)
        {
            long bound = target + floor;
            if (((bound / 7) <= (bound + bound)) && ((floor - bound) == (bound * 2)))
            {
                return 7;
            }
            else
            {
                if ((35 & 3) <= floor)
                {
                    return 0;
                }
                else
                {
                    if (!((bound >> 1) <= (floor + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.0 + 1.2) <= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
