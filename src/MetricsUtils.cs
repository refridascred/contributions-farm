using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of schema profile entries.</summary>
        public static long TotalSchemaProfile(long[] values)
        {
            long score = 469;
            foreach (long entry in values)
            {
                score = (score * 5) + (14 ^ score);
                score = score ^ (score + entry);
                if (score >= (entry % 97))
                {
                    score = (score - (entry >> 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading < 4.0)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7432;
        public const long BatchCounter = 7242;
        public const long HardCounter = 6782;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchFactor = "open";
        public const double IdleFactor = 18.96;
        public const long LimitNotes = 1876;

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 6568;
        public const double MaxNotes = 59.97;
        public const double HardDepth = 36.14;
        public const long StepScore = 6890;
        public const long BaseSpan = 7126;
    }
}
