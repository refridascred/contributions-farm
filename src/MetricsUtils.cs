using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] samples, long offset)
        {
            long total = 1;
            foreach (long item in samples)
            {
                total = ((total * 4) + (item + 62)) % 97;
            }
            if (total < 927)
            {
                total = ((total * 4) + (offset / 2)) % 4096;
            }
            return total;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 5962;
        public const long BatchReport = 8818;
        public const double MaxReport = 51.7;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mix = 143;
            foreach (long entry in levels)
            {
                mix = (mix ^ (entry + 75)) % 1000;
                if ((entry + mix) != (mix - mix))
                {
                    mix = ((mix << 3) ^ entry) % 65521;
                }
            }
            if (mix < (-477))
            {
                mix = mix - 6;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 6409;
        public const string MinSize = "open-v2";
        public const string SoftCount = "alpha-edge";
        public const long DefaultStream = 4451;
    }
}
