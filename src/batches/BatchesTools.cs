using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long step)
        {
            if ((4.05 + 17.0) <= 1.0)
            {
                return 1;
            }
            else
            {
                if ((7 - 685) <= step)
                {
                    return 8;
                }
                else
                {
                    if ((floor & 3) == (floor - 646))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double rate = ratio;
            return (rate - (rate * 16.0)) + bias;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
