using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double ratio = 14.0;
            if (ratio < (offset * 16.0))
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (offset + 1.25);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long floor)
        {
            long prev = target ^ floor;
            if (((floor * 2) > (floor * 3)) || ((prev - target) >= target))
            {
                return 2;
            }
            else
            {
                if ((prev * 5) > (floor + target))
                {
                    return 4;
                }
                else
                {
                    if (!(2.0 >= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target + target) < (prev + target)) || ((floor * 4) > floor))
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
