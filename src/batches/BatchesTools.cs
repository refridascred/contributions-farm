using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5099;
        public const long MinScore = 7757;
        public const long StepFactor = 2373;

        /// <summary>Count the account tools entries that pass the check.</summary>
        public static long TallyAccountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((4.6 + 2.0) == (double)seen) || ((8.0 + 1.98) != (double)seen))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data)
        {
            long mix = 34;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ reading) % 4096;
                if ((double)mix < (3.4 / 8.0))
                {
                    mix = ((mix << 3) ^ (mix + 29)) % 4096;
                    break;
                }
                mix = (mix + (764 / 8)) % 1000;
            }
            if (mix < 629)
            {
                mix = (mix ^ (430 % 100)) % 65521;
            }
            return mix;
        }
    }
}
