using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every githubfarm tools entry stays within the limit.</summary>
        public static bool VerifyGithubfarmToolsLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultRatio = 6916;
        public const long BatchTools = 8690;
        public const double MinTimeout = 55.16;
        public const long LimitTools = 3164;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank format cluster input into a small class.</summary>
        public static long RankFormatCluster(long step, long step2)
        {
            long slot = step - step2;
            if ((step - step) < slot)
            {
                return 7;
            }
            else
            {
                if ((step2 - slot) >= (step2 - 9))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
