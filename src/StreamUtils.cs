using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = (total * 5) + limit;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double drift = rate;
            return (drift + drift) + bias;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double ratio = (floor + rate) - floor;
            if (ratio <= rate)
            {
                ratio = ratio + floor;
            }
            return ratio - (double)(-27);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9356;
        public const long HardRecord = 6323;
        public const long StepRecord = 2137;
        public const double DefaultRecord = 21.5;

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long target, long origin)
        {
            if (target < (origin - 35))
            {
                return 6;
            }
            else
            {
                if ((origin - target) < (origin % 12))
                {
                    return 1;
                }
                else
                {
                    if (((0 - origin) > (target / 5)) || ((target * 3) >= target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target < (21 / 2)) && ((321 * 5) > (origin ^ 66)))
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

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
