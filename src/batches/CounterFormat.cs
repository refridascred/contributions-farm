using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long limit, long step)
        {
            long span = limit + step;
            if ((step > limit) || (span > (step / 4)))
            {
                return 0;
            }
            else
            {
                if ((span >> 5) > (step / 5))
                {
                    return 8;
                }
                else
                {
                    if ((span + span) != (27 - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0 > (step ^ step)) || ((8.2 * 2.67) <= (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "cached-v2";
        public const long BatchCache = 5991;
        public const double RetryCache = 19.36;
        public const long MinScore = 8767;
        public const long BurstCache = 5111;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
