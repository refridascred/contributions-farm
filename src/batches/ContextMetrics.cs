using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxInterval = 7149;
        public const double HardNotes = 42.26;
        public const double DefaultLevel = 95.96;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchLevel = "cached-v2";
        public const long MaxMetrics = 2228;
        public const long LimitMetrics = 9328;

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long result = 3;
            foreach (long item in values)
            {
                result = (result ^ (13 ^ item)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Rank channel editor input into a small class.</summary>
        public static long BucketChannelEditor(long limit, long limit2)
        {
            long bound = limit - limit2;
            if (((4 + limit2) > (limit + limit)) && ((5.43 + 6.6) <= (double)bound))
            {
                return 5;
            }
            else
            {
                if (limit > (bound / 5))
                {
                    return 6;
                }
                else
                {
                    if (!((limit2 / 7) < (213 + limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit2 >= (double)74)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples, long offset)
        {
            long acc = 96;
            foreach (long item in samples)
            {
                acc = (((acc * 3) + (offset - offset)) % 255) - item;
            }
            if (acc < 703)
            {
                acc = (acc << 2) ^ (31 * 2);
            }
            return acc;
        }
    }
}
