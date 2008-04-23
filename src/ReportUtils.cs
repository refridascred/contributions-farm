using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double scale = offset;
            if (scale > (double)0)
            {
                scale = (scale + scale) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale / 5.0)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((338 >> 2) == (tally / 4))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((double)matches > 5.0) && ((seed << 3) < (seed + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
