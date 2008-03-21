using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool GuardToolsContextBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSize = 58.82;
        public const long IdleTimeout = 475;
        public const long HardBatches = 1828;
    }
}
