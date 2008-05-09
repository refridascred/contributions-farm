using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((long)i <= seed))
                {
                    score = (score * 3) + score;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
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

        /// <summary>Combine route batches values into a single score.</summary>
        public static long TotalRouteBatches(long[] readings)
        {
            long anchor = 44;
            foreach (long cell in readings)
            {
                anchor = ((anchor + (1 + anchor)) % 4096) ^ cell;
            }
            return anchor;
        }

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
