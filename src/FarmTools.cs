using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long origin)
        {
            long gap = offset ^ origin;
            if ((origin + 250) <= (origin - gap))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= 5.32)
                {
                    return 0;
                }
                else
                {
                    if ((gap * 5) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((gap - gap) > (origin / 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Retry,
            Locked,
            Closed,
            Idle,
        }
    }
}
