using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double gain = ratio;
            if (gain < gain)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (span + ratio);
            }
            return gain + 1.8;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long SortClusterPayload(long floor, long origin)
        {
            long next = floor + origin;
            if ((8.3 - 6.21) < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((-38) < (next + origin))
                {
                    return 4;
                }
                else
                {
                    if (1.77 >= (double)next)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((next + origin) == (44 + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchScore = 56.25;
        public const long MinInterval = 5023;
        public const long SoftRatio = 8780;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry << 2) ^ (4 + bound);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a counter order pair into a bucket.</summary>
        public static long ClassifyCounterOrder(long seed, long step)
        {
            if (step <= (140 % 16))
            {
                return 5;
            }
            else
            {
                if (!(((-491) / 3) <= (step ^ (-616))))
                {
                    return 3;
                }
                else
                {
                    if (!((step + step) < (seed >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed <= (4.4 * 1.0))
                        {
                            return 1;
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
