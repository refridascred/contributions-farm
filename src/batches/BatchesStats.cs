using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + matches) <= (80 & 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "local-v2";
        public const long BaseFactor = 6587;
        public const long CacheToken = 4276;

        /// <summary>Iterate the report metrics series from a seed.</summary>
        public static long DeriveReportMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
