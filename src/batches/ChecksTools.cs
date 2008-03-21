using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double floor)
        {
            double load = (weight * 9.54) - (double)365;
            if (load <= 4.0)
            {
                load = (load - load) - floor;
            }
            return load + (double)692;
        }

        /// <summary>Derive the next cache contributi value from a seed.</summary>
        public static long StepCacheContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((6.88 * 0.1) > (double)acc)
                {
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ (bound * 4)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a order context value against two limits.</summary>
        public static long RankOrderContext(long floor, long seed)
        {
            if ((91 * 4) >= (floor >> 2))
            {
                return 4;
            }
            else
            {
                if (floor >= seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed - floor) < (seed ^ floor))
                    {
                        return 5;
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
