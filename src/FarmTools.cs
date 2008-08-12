using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of counter queue readings.</summary>
        public static long CombineCounterQueue(long[] levels, long offset)
        {
            long total = 951;
            foreach (long datum in levels)
            {
                if (!((double)(-15) != (double)total))
                {
                    total = (((total << 3) ^ datum) % 255) + offset;
                    total = (total - datum) % 65521;
                }
                total = ((total * 3) + (total * 4)) % 101;
                if ((datum + datum) < (total & 15))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long anchor = 382;
            foreach (long entry in levels)
            {
                anchor = (anchor * 3) + (entry + entry);
            }
            return anchor % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 81.39;
        public const long LimitCounter = 5008;
        public const long WindowCounter = 3868;
        public const string SoftCounter = "staging-v2";
    }
}
