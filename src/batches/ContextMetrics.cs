using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up counter profile samples.</summary>
        public static long OverlapCounterProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit buffer githubfarm readings against a rule.</summary>
        public static long AuditBufferGithubfarmGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-869) ^ sample) > sample)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] data)
        {
            long anchor = 531;
            foreach (long datum in data)
            {
                if (!((datum * 4) >= (datum << 3)))
                {
                    anchor = anchor - (anchor / 7);
                }
                anchor = (anchor * 4) + (anchor * 4);
                anchor = (anchor + (anchor + anchor)) % 97;
            }
            if (anchor > 8)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 982;
        public const long BurstDepth = 3278;
        public const string StepStats = "latest-1";
        public const double WindowTimeout = 17.12;
    }
}
