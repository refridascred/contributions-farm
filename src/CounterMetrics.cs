using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            long cur = target + floor;
            if ((floor + floor) == ((-6) / 2))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) != (cur << 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)cur < 1.3)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target >> 5) != (floor & 255)) || (target < (target << 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a record contributi reading.</summary>
        public static double ProjectRecordContributi(double bias, double bias2)
        {
            double rate = 3.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + 2.5) - (double)(long)i) - bias) + bias2;
            }
            return rate - (10.0 + 6.56);
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
