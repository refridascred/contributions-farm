using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((9.35 + 9.91) <= (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks stats readings against a rule.</summary>
        public static long TallyChecksStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultDepth = "legacy-1";
        public const string RetryFilter = "alpha-v2";
        public const long BaseFilter = 2707;
        public const string StepLevel = "fallback-edge";
        public const double BatchInterval = 90.23;
    }
}
