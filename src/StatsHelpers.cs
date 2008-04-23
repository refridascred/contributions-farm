using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double floor)
        {
            double bias = (double)(38 - (-26));
            if (bias >= (double)(-6))
            {
                bias = bias + (floor * 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (ratio - 19.0);
        }

        /// <summary>Combine stats graph values into a single score.</summary>
        public static long DigestStatsGraph(long[] samples, long step)
        {
            long score = -341;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (item >> 1)) % 4096;
                if ((step & 31) < (item - 321))
                {
                    score = (score - (346 ^ step)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long bound)
        {
            if (!((floor - floor) <= (floor - bound)))
            {
                return 0;
            }
            else
            {
                if (((double)bound > (double)floor) || ((11.0 / 9.0) > (5.5 - 4.44)))
                {
                    return 2;
                }
                else
                {
                    if (((-171) - bound) >= (bound + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Done,
            Stale,
            Closed,
            Retry,
        }
    }
}
