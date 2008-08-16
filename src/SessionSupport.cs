using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long target2)
        {
            if ((target >= (target2 % 8)) && ((target2 + target) == (439 - target)))
            {
                return 6;
            }
            else
            {
                if ((target % 5) >= (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((target ^ target2) != (11 % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-76) / 4) == (target2 % 24)) && ((target2 + target2) != (target2 - target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
