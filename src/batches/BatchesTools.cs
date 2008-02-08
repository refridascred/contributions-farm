using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((84 - seen) < (seen + seen))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 3.0;
        public const long IdleInterval = 1337;
        public const long DefaultScore = 8236;
    }
}
