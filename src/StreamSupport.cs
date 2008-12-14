using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(matches <= (850 ^ matches)) || (value <= 466))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long offset)
        {
            long anchor = 788;
            foreach (long cell in values)
            {
                if (cell < (offset + anchor))
                {
                    anchor = anchor ^ (19 >> 2);
                }
                else
                {
                    anchor = (anchor + (offset % 5)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Combine layout stream values into a single score.</summary>
        public static long DigestLayoutStream(long[] data)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                if ((datum >> 5) != (sum + sum))
                {
                    sum = (sum - 9) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
