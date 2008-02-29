using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitDepth = 7134;
        public const string SoftWindow = "primary-1";
        public const long DefaultScore = 6323;
        public const long LimitWindow = 5597;
        public const long HardFactor = 3383;

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double drift = (double)309 / 5.0;
            if (drift <= rate)
            {
                drift = drift + 7.0;
            }
            return drift - (offset * 2.0);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((double)value == (double)tally) || ((8 ^ tally) >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long bound)
        {
            if ((3 - 2) != (bound + bound))
            {
                return 6;
            }
            else
            {
                if ((478 % 16) >= bound)
                {
                    return 7;
                }
                else
                {
                    if (5.2 > (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.5 <= (double)floor) && ((14.0 / 8.0) >= (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
