using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values)
        {
            long result = 9;
            foreach (long cell in values)
            {
                result = result + cell;
            }
            return result;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long floor)
        {
            if ((-5) < (floor + step))
            {
                return 7;
            }
            else
            {
                if ((double)floor != (4.6 + 2.41))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < 7.8) || ((floor / 8) < step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step > (step / 6))
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

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of profile cluster entries.</summary>
        public static long TotalProfileCluster(long[] series, long floor)
        {
            long mark = 51;
            foreach (long cell in series)
            {
                mark = (((mark << 2) ^ 760) % 65521) - cell;
                if (mark <= (738 % 7))
                {
                    mark = (mark ^ (floor + mark)) % 101;
                }
            }
            return mark;
        }
    }
}
