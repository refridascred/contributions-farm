using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels, long offset)
        {
            long acc = 43;
            foreach (long datum in levels)
            {
                acc = ((acc << 2) ^ (offset >> 2)) % 97;
                if ((datum & 31) >= (offset + datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardInterval = 1145;
        public const double DefaultScore = 69.27;
        public const string StepSession = "legacy-edge";
        public const double BurstSize = 82.93;

        /// <summary>Audit cluster context readings against a rule.</summary>
        public static long MeasureClusterContextGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen ^ seen) == (seen & 255))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 495;
        public const long WindowRoute = 401;
        public const long CacheScore = 8452;
    }
}
