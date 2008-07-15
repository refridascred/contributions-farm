using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two schema editor measurements.</summary>
        public static double ScaleSchemaEditor(double scale, double floor)
        {
            double load = scale / 5.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (double)49) - (double)(long)i) - floor;
            }
            return load - scale;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data, long bound)
        {
            long anchor = 878;
            foreach (long cell in data)
            {
                anchor = (((anchor << 3) ^ (cell << 2)) % 101) - bound;
            }
            if (anchor < 71)
            {
                anchor = ((anchor << 2) ^ (anchor - 93)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "primary";
        public const string BurstCount = "cached-v2";
        public const double StepContext = 57.66;
        public const long CacheContext = 2548;
    }
}
