using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double bias)
        {
            double bias2 = 1.0 - scale;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - (double)661) + (double)(long)i) - bias;
            }
            return bias2 - scale;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long target)
        {
            if ((target > (498 + step)) || ((278 - 699) == (target >> 5)))
            {
                return 7;
            }
            else
            {
                if ((double)target < (8.26 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if (((34 - (-30)) >= (step << 3)) || ((target << 1) >= step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4 << 1) < target)
                        {
                            return 3;
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
