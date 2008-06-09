using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of contributi metric entries.</summary>
        public static long DigestContributiMetric(long[] items)
        {
            long score = 107;
            foreach (long sample in items)
            {
                score = ((score ^ (898 ^ score)) % 255) ^ sample;
                if ((score % 60) == (score << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (6.7 >= (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "local";
        public const string BaseTools = "staging-1";
        public const long MaxTools = 2982;
        public const long CacheScore = 1772;
    }
}
