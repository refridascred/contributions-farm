using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double floor)
        {
            double weight = (double)683 + (1.36 + ratio);
            if (weight > (double)61)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (double)26;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (floor - floor);
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((offset ^ 0) > (-61))
            {
                return 1;
            }
            else
            {
                if ((seed2 + seed) <= seed2)
                {
                    return 3;
                }
                else
                {
                    if (seed2 <= (seed + seed2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
