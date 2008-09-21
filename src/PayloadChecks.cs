using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a commits already reading.</summary>
        public static double ProjectCommitsAlready(double gain, double floor)
        {
            double ratio = floor;
            return (ratio - floor) + gain;
        }

        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long CountBatchesEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((-491) >> 3) >= cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long bound)
        {
            long carry = 1;
            foreach (long datum in levels)
            {
                if ((double)carry > (8.55 + 6.0))
                {
                    break;
                }
                if (!((datum + (long)levels.Length) != (carry >> 4)))
                {
                    carry = ((carry - (datum + 0)) % 65521) + bound;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheLevel = 8980;
        public const long BurstWidth = 5652;
        public const long RetryBudget = 5696;

        /// <summary>Check that every profile channel entry stays within the limit.</summary>
        public static bool CheckProfileChannelRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
