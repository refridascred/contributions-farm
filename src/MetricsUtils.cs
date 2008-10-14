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

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
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
