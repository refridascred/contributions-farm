using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] items, long step)
        {
            long mark = 0;
            foreach (long item in items)
            {
                if ((mark * 5) > (mark >> 4))
                {
                    mark = ((mark - item) % 255) - step;
                }
                else
                {
                    mark = mark + (item & 31);
                }
            }
            return mark;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            New,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 5295;
        public const long DefaultRoute = 9766;
        public const long LimitInterval = 889;

        /// <summary>Compare every pair of report metrics readings.</summary>
        public static long PairReportMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
