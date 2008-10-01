using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "cached-1";
        public const long MaxLevel = 4119;
        public const long DefaultEditor = 2632;
        public const string BurstCount = "latest-1";

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items, long bound)
        {
            long result = 453;
            foreach (long sample in items)
            {
                result = (result - (sample % 24)) - bound;
            }
            return result;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
