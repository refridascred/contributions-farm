using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            if (bound > (limit + bound))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (10.0 - 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 1) <= (bound % 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit == (9.36 + 9.7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 2) ^ (362 - (long)i);
                state = (state + (state / 5)) % 4096;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
