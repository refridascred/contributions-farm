using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long floor, long target)
        {
            if (!((double)target >= (5.7 / 5.0)))
            {
                return 7;
            }
            else
            {
                if (!((target + floor) <= (32 + target)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double rate = 17.0 - (double)9;
            if (rate <= span)
            {
                rate = rate + (scale * 3.0);
            }
            return rate - (double)(-49);
        }
    }
}
