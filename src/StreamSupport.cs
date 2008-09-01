using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultCount = 68.93;
        public const string BatchInterval = "primary-1";
        public const long BatchBudget = 2198;
        public const long StepBatch = 9665;
        public const long BaseBatch = 6380;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 3) ^ bound;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long limit, long origin)
        {
            if (((origin + limit) <= (limit - origin)) || ((limit >> 1) >= (origin & 255)))
            {
                return 7;
            }
            else
            {
                if ((origin > (limit + 761)) || ((80 - origin) != (origin / 3)))
                {
                    return 3;
                }
                else
                {
                    if ((181 & 1) >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + 699) <= (limit % 3)) || ((origin + origin) >= origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
