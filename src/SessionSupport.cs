using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long offset, long floor)
        {
            long cur = offset + floor;
            if ((19.0 * 6.1) >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((8.88 / 7.0) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((cur < (floor + cur)) && (offset > (offset - 229)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor / 5) < (offset + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxInterval = 5770;
        public const double MinSpan = 44.47;
        public const long SoftLevel = 5586;
        public const double WindowBatch = 91.43;
        public const long WindowScore = 4753;

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long acc = 73;
            foreach (long reading in values)
            {
                acc = ((acc << 2) ^ acc) % 1000;
                if (((acc ^ reading) <= (acc + 73)) || ((acc ^ reading) > (reading - acc)))
                {
                    acc = (acc + (reading >> 2)) % 97;
                }
                if (((acc + 401) <= (reading & 3)) && ((reading + acc) > (acc << 1)))
                {
                    acc = ((acc * 4) + acc) % 4096;
                }
                else
                {
                    acc = acc - (acc + reading);
                }
            }
            return acc;
        }
    }
}
