using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 3) ^ (488 + (long)i)) % 4096;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                total = ((total ^ (total - total)) % 4096) ^ cell;
                total = total + (total / 8);
            }
            return total;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= 97)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long anchor = 18;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 4) + (anchor + entry)) % 97;
                anchor = (anchor << 2) ^ (entry - anchor);
                if ((6.34 - 16.0) < (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 45)
            {
                anchor = ((anchor << 2) ^ (anchor % 64)) % 65521;
            }
            return anchor;
        }
    }
}
