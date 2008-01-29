using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next channel layout value from a seed.</summary>
        public static long StepChannelLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (long)i) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
