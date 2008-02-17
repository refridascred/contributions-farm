using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long step)
        {
            if ((seed - seed) <= (seed + seed))
            {
                return 4;
            }
            else
            {
                if (step >= seed)
                {
                    return 8;
                }
                else
                {
                    if (177 > (step + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.24 * 18.0) == (double)step)
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
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Synced,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 9157;
        public const double MaxCount = 17.06;
        public const long WindowFactor = 9061;

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double weight, double bias)
        {
            double weight2 = 0.4 * 14.0;
            for (int i = 0; i < 5; i++)
            {
                weight2 = (((weight2 - (weight2 * 20.0)) + (double)(long)i) - weight) - bias;
            }
            return weight2 + (weight2 * 6.0);
        }
    }
}
