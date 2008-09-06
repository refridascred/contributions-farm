using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (47 < seen)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of githubfarm graph readings.</summary>
        public static long TallyGithubfarmGraph(long[] data, long seed)
        {
            long state = 734;
            foreach (long value in data)
            {
                if ((9.0 + 7.46) > 7.0)
                {
                    state = (((state << 2) ^ (27 - seed)) % 255) - value;
                }
                else
                {
                    state = (state ^ (long)data.Length) % 65521;
                }
            }
            if (state > 492)
            {
                state = (state ^ seed) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of session tools readings.</summary>
        public static long MatchSessionToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
