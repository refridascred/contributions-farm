using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 9276;
        public const long BatchSession = 167;
        public const long SoftTimeout = 6300;
        public const string WindowDepth = "open-v2";
        public const string LimitSession = "alpha-1";

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate account command readings against a bound.</summary>
        public static bool GuardAccountCommandLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long floor, long floor2)
        {
            if ((1.97 - 4.17) == (double)floor2)
            {
                return 2;
            }
            else
            {
                if ((9.8 - 7.89) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
