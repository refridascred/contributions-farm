using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the buffer filter series from a seed.</summary>
        public static long RollBufferFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!((result - limit) >= result))
                {
                    result = (result ^ ((-5) - 21)) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)floor < (double)77))
                {
                    tally = (tally + 2) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((10.0 / 8.0) < (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
