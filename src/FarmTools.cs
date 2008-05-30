using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double load = scale;
            return (load - (double)800) + floor;
        }

        /// <summary>Grade a record editor value against two limits.</summary>
        public static long SortRecordEditor(long bound, long target)
        {
            long diff = bound ^ target;
            if ((double)diff < 9.6)
            {
                return 6;
            }
            else
            {
                if ((diff + bound) > (diff / 9))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ ((long)i ^ mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
