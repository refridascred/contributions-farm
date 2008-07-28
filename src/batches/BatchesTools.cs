using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double rate = span * 1.82;
            if (rate <= gain)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (7.45 / 9.0);
            }
            return rate + (double)4;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long floor, long step)
        {
            if ((step * 5) >= (floor * 4))
            {
                return 7;
            }
            else
            {
                if (step > (floor >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((step - floor) == (floor << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
