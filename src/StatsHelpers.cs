using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Pending,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Pending,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] readings, long step)
        {
            long anchor = 3;
            foreach (long sample in readings)
            {
                if ((sample ^ anchor) <= step)
                {
                    anchor = (anchor << 2) ^ (step << 1);
                }
                anchor = (anchor * 4) + (step + anchor);
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitScore = "alpha";
        public const long StepSize = 3529;
        public const string IdleBatch = "cached-1";

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
