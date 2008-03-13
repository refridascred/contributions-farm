using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long floor, long target)
        {
            if ((target / 7) <= target)
            {
                return 6;
            }
            else
            {
                if (((double)floor >= (4.41 - 3.29)) && (64 > (floor * 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((limit << 3) >= (edge << 2))
            {
                return 2;
            }
            else
            {
                if (limit < (limit + 260))
                {
                    return 7;
                }
                else
                {
                    if (972 >= (limit << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge + limit2) > edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
