using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a schema counter value against two limits.</summary>
        public static long ClassifySchemaCounter(long floor, long seed)
        {
            long delta = floor ^ seed;
            if (4.1 > (double)delta)
            {
                return 8;
            }
            else
            {
                if ((floor > (delta + floor)) && ((0.2 / 6.0) >= (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (47 <= (seed >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >= delta) || ((double)delta < (8.57 - 2.8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            if (bound > seed)
            {
                return 3;
            }
            else
            {
                if (bound >= (seed - bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
