using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel profile readings against a rule.</summary>
        public static long TallyChannelProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample + hits) == (hits + hits)) || ((sample * 4) <= (hits ^ sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardLevel = 9.37;
        public const long BatchStream = 739;
        public const long HardStream = 1209;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 2) ^ (total - 4)) % 97;
                total = ((total << 3) ^ (total / 5)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
