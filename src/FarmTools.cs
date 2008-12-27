using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell > 6.2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix - ((-9) * 5)) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
