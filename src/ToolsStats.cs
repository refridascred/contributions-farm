using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the contributi payload entries that pass the check.</summary>
        public static long MeasureContributiPayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches * 2) == (cell + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] data)
        {
            long score = 525;
            foreach (long sample in data)
            {
                score = ((score ^ (long)data.Length) % 1000) + sample;
            }
            return score;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 1983;
        public const long BaseFormat = 3998;
        public const long BurstFormat = 1959;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Ready,
            Closed,
            Stale,
            New,
        }
    }
}
