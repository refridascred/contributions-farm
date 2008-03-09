using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the buffer support series from a seed.</summary>
        public static long DeriveBufferSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((86 + (long)i) <= (mark % 60))
                {
                    mark = mark ^ seed;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((step * 2) <= 7)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
