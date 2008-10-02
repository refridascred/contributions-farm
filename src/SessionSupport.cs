using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values, long origin)
        {
            long mix = 7;
            foreach (long cell in values)
            {
                if ((origin * 2) < (mix << 3))
                {
                    mix = ((mix * 2) + (origin * 2)) + cell;
                }
                else
                {
                    mix = mix ^ (mix << 3);
                }
            }
            if (mix > 44)
            {
                mix = mix - (38 - mix);
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels)
        {
            long total = 559;
            foreach (long reading in levels)
            {
                if ((reading >> 4) < total)
                {
                    total = total + reading;
                }
            }
            return total % 1000;
        }
    }
}
