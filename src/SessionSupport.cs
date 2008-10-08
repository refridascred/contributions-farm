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

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
