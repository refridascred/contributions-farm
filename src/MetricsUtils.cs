using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Queued,
            Locked,
            New,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] samples, long floor)
        {
            long sum = 281;
            foreach (long datum in samples)
            {
                if (276 < (floor - sum))
                {
                    sum = ((sum * 2) + (floor + floor)) + datum;
                }
                else
                {
                    sum = sum ^ (sum * 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepBudget = 45.44;
        public const double DefaultReport = 4.35;
        public const long RetryFactor = 477;

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((seen / 8) <= (seen + target)))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
