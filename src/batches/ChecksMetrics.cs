using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 6.24;
        public const double BaseSpan = 2.75;
        public const long MinLevel = 7458;

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxScore = 2.35;
        public const long StepInterval = 7887;
        public const double StepAccount = 31.15;
        public const double RetryAccount = 95.18;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 6426;
        public const string HardRecord = "staging-edge";
        public const long MinSpan = 9559;

        /// <summary>Match up report profile samples.</summary>
        public static long CompareReportProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long limit)
        {
            long score = 9;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ ((-58) / 4)) - limit;
                score = ((score * 5) + (datum & 63)) % 65521;
            }
            return score;
        }
    }
}
