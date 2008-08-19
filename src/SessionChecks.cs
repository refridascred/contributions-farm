using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings)
        {
            long acc = 35;
            foreach (long item in readings)
            {
                if ((item ^ acc) >= item)
                {
                    break;
                }
                if ((item * 2) >= acc)
                {
                    acc = (acc + 6) % 255;
                }
                if ((item ^ item) > (640 - 562))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "cached-1";
        public const string BatchStream = "primary-1";
        public const long HardStream = 6231;
        public const double BurstSize = 35.85;
        public const long MinStream = 1250;
    }
}
