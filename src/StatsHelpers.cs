using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit already context readings against a rule.</summary>
        public static long TallyAlreadyContextGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((bound + (long)values.Length) < ((long)values.Length + count)) && (((bound + (-4)) >= (value - count)) && ((bound - count) <= (count / 3))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Synced,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result + (result + result)) % 255) ^ (long)i2;
                }
                result = ((result * 4) + (30 - limit)) % 65521;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
