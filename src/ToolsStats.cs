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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Measure how many cache cluster samples are out of range.</summary>
        public static long MeasureCacheClusterMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (19.0 >= (double)item)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 9468;
        public const long BatchCount = 7504;
        public const long BurstSchema = 7359;
        public const long LimitWidth = 9185;
        public const long BaseInterval = 5102;
    }
}
