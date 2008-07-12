using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheTimeout = "strict-1";
        public const long WindowEditor = 8559;
        public const long SoftEditor = 6058;

        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long DigestBatchBuffer(long[] series)
        {
            long total = -61;
            foreach (long value in series)
            {
                if ((total & 255) == (value + total))
                {
                    total = (total + (value >> 2)) % 255;
                }
            }
            if (total > 830)
            {
                total = ((total << 3) ^ ((long)series.Length & 7)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next token githubfarm value from a seed.</summary>
        public static long SeriesTokenGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
