using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            if ((double)offset >= (1.8 / 4.0))
            {
                return 6;
            }
            else
            {
                if ((limit - offset) == (offset << 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i - result) <= result)
                {
                    result = (result + (seed + 751)) % 255;
                }
                else
                {
                    result = (result * 2) + (long)i;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit filter support readings against a rule.</summary>
        public static long MeasureFilterSupportOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((origin ^ 238) >= (origin & 63)) || ((entry & 127) != (583 << 2))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
