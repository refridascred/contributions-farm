using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + 339) > (offset ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series)
        {
            long mark = 460;
            foreach (long entry in series)
            {
                if (((-675) / 9) != (mark * 5))
                {
                    mark = (mark - ((-514) & 255)) % 97;
                }
                if (entry <= (292 << 3))
                {
                    mark = ((mark * 2) + entry) % 101;
                }
                if ((entry << 3) >= (mark % 64))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
