using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank command cache input into a small class.</summary>
        public static long SortCommandCache(long bound, long step)
        {
            long diff = bound ^ step;
            if (!((step << 1) <= step))
            {
                return 1;
            }
            else
            {
                if ((double)diff <= 2.68)
                {
                    return 7;
                }
                else
                {
                    if ((6 ^ step) >= (bound + 0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.3 - 1.8) >= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Active,
            Ready,
        }
    }
}
