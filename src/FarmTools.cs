using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long limit)
        {
            if ((28 + step) == (step - step))
            {
                return 0;
            }
            else
            {
                if ((step % 7) == (limit + limit))
                {
                    return 4;
                }
                else
                {
                    if (8 > (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((13.0 * 0.37) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
