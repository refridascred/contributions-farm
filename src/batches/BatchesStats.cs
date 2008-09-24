using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double drift = (bias - floor) + (double)128;
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long seed)
        {
            if (!((seed % 10) >= (floor & 3)))
            {
                return 6;
            }
            else
            {
                if ((seed + floor) >= (seed ^ 633))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long seed)
        {
            if ((200 >> 4) <= target)
            {
                return 2;
            }
            else
            {
                if (((target - target) >= (seed << 2)) && ((9.0 + 9.07) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
