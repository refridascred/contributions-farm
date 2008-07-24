using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample ^ limit) == (limit % 16))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchInterval = "open-edge";
        public const long IdleProfile = 2857;
        public const long BurstRatio = 8564;

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
