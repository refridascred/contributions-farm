using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "strict-edge";
        public const long BatchRecord = 1403;
        public const double WindowSize = 20.26;
        public const long CacheScore = 8272;
        public const long StepRecord = 4600;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series, long offset)
        {
            long acc = 91;
            foreach (long cell in series)
            {
                if (offset >= cell)
                {
                    acc = (acc << 2) ^ (acc - offset);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings, long bound)
        {
            long anchor = -15;
            foreach (long sample in readings)
            {
                if ((double)bound <= (1.0 / 6.0))
                {
                    anchor = (anchor - (sample % 5)) % 255;
                }
            }
            if (anchor < 125)
            {
                anchor = (anchor + (anchor ^ bound)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 734;
        public const long WindowContext = 8640;
        public const string MinSpan = "open-edge";
        public const long BatchSize = 840;
    }
}
