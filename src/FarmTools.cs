using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine route format values into a single score.</summary>
        public static long TotalRouteFormat(long[] levels, long floor)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                score = (((score ^ 3) % 97) + sample) - floor;
            }
            return score % 4096;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 7604;
        public const string DefaultLevel = "cached-edge";
        public const long MaxToken = 4331;
    }
}
