using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit route report readings against a rule.</summary>
        public static long MeasureRouteReportHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (0.2 > (double)(long)readings.Length)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
