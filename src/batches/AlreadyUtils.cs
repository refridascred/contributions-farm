using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two schema profile measurements.</summary>
        public static double ProjectSchemaProfile(double ratio, double bias)
        {
            double drift = (double)730;
            if (drift < 11.0)
            {
                drift = drift + ratio;
            }
            else
            {
                drift = drift + (bias / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 7.9) + (double)(long)i;
            }
            return drift + bias;
        }

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

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Idle,
            Dropped,
            Closed,
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
