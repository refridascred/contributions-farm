using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long bound2)
        {
            long next = bound + bound2;
            if (!((bound2 + next) == (bound << 2)))
            {
                return 5;
            }
            else
            {
                if (next <= (next - bound))
                {
                    return 3;
                }
                else
                {
                    if ((3.2 / 5.0) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.0 - 8.27) == (double)bound2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
