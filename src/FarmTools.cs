using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long limit2)
        {
            long next = limit - limit2;
            if (limit >= ((-51) << 2))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (double)next)
                {
                    return 5;
                }
                else
                {
                    if ((limit2 >> 3) < next)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit2) >= (limit2 - limit2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
