using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                if ((score >> 5) <= (91 + cell))
                {
                    score = score - (score << 2);
                }
                if (65 > (cell ^ cell))
                {
                    break;
                }
            }
            if (score > 340)
            {
                score = score ^ (score & 127);
            }
            return score;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinTimeout = 525;
        public const long HardDepth = 9461;
        public const long RetryRoute = 9354;
        public const long StepWidth = 532;
        public const long CacheRoute = 1815;

        /// <summary>Count the githubfarm commits entries that pass the check.</summary>
        public static long CountGithubfarmCommitsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((seen - 58) > (seen & 127)) || ((reading <= (seen * 5)) || ((double)reading <= (5.98 * 3.18))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
