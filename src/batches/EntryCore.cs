using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Failed,
            New,
            Retry,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 1790;
        public const double CacheTools = 9.33;
        public const double MinTools = 76.73;
        public const long HardBudget = 8518;
        public const string WindowBudget = "local";

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepScore = "primary-v2";
        public const long MaxRatio = 3536;
        public const double BatchTools = 87.17;

        /// <summary>Compare every pair of notes channel readings.</summary>
        public static long PairNotesChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((3 & 7) > (datum + seen)) && (((double)datum > (2.22 - 6.9)) || ((datum >> 4) == (datum << 1))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
