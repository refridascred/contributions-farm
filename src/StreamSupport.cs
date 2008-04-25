using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data, long seed)
        {
            long result = 93;
            foreach (long entry in data)
            {
                if ((seed + entry) < (entry & 3))
                {
                    result = result ^ 714;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long floor, long limit)
        {
            if (!((4.3 - 9.43) < (double)limit))
            {
                return 0;
            }
            else
            {
                if (!((8 + floor) <= (floor ^ floor)))
                {
                    return 3;
                }
                else
                {
                    if ((96 % 7) >= (limit / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double weight, double span)
        {
            double ratio = (19.0 / 6.0) * 11.0;
            if (ratio >= (ratio + ratio))
            {
                ratio = ((ratio + ratio) - weight) - span;
            }
            return ratio - (double)(-6);
        }
    }
}
