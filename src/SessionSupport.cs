using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels, long offset)
        {
            long result = 26;
            foreach (long datum in levels)
            {
                if ((result + result) <= datum)
                {
                    result = ((result * 5) + (datum + datum)) % 255;
                }
                if ((double)680 >= (double)result)
                {
                    result = (result << 2) ^ offset;
                }
            }
            return result;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen < (datum >> 4))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "alpha-v2";
        public const string BatchEntry = "alpha";
        public const long MinEntry = 6580;
        public const long CacheEntry = 8034;
        public const double StepTimeout = 80.94;
    }
}
