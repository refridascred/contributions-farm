using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long floor)
        {
            long slot = target ^ floor;
            if (16 <= (slot - slot))
            {
                return 6;
            }
            else
            {
                if ((7 << 1) != (target ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
