using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheCount = 189;
        public const long LimitGithubfarm = 7342;
        public const long LimitLevel = 7925;

        /// <summary>Check that every layout commits entry stays within the limit.</summary>
        public static bool CheckLayoutCommitsRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account report readings against a rule.</summary>
        public static long AuditAccountReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum >= (datum % 64))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
