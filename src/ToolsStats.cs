using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long step)
        {
            long lane = offset + step;
            if ((double)lane >= (6.0 * 5.4))
            {
                return 2;
            }
            else
            {
                if (5.0 < (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((lane + lane) == (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 9468;
        public const long BatchCount = 7504;
        public const long BurstSchema = 7359;
        public const long LimitWidth = 9185;
        public const long BaseInterval = 5102;
    }
}
