using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long bound)
        {
            if ((double)seed >= (7.3 / 5.0))
            {
                return 8;
            }
            else
            {
                if (bound >= (bound + 3))
                {
                    return 3;
                }
                else
                {
                    if (seed > (bound & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long bound)
        {
            if ((bound * 5) <= (-6))
            {
                return 7;
            }
            else
            {
                if ((step * 2) <= (step + bound))
                {
                    return 5;
                }
                else
                {
                    if ((5.11 + 1.9) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
