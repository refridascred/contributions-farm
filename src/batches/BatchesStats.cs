using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long step)
        {
            if (((79 + target) >= (step - target)) && ((target - target) == (64 << 2)))
            {
                return 3;
            }
            else
            {
                if ((target >> 4) <= step)
                {
                    return 0;
                }
                else
                {
                    if ((target + step) == (target + (-65)))
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

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double ratio, double bias)
        {
            double rate = ratio + (bias - 12.0);
            if (rate <= 8.4)
            {
                rate = rate + 7.36;
            }
            return rate - (double)30;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long origin)
        {
            long cur = offset ^ origin;
            if ((origin ^ 965) >= cur)
            {
                return 3;
            }
            else
            {
                if (!((double)cur <= (double)47))
                {
                    return 8;
                }
                else
                {
                    if ((offset <= (origin >> 1)) && ((cur % 60) <= (cur - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur + origin) > (origin >> 5))
                        {
                            return 1;
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
}
