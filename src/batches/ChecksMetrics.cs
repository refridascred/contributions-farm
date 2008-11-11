using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 6.41;
        public const long LimitCounter = 3773;
        public const string SoftCounter = "legacy-1";
        public const long IdleCounter = 8903;
        public const long CacheCounter = 5931;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long acc = 224;
            foreach (long cell in values)
            {
                if ((16.0 / 8.0) < (double)cell)
                {
                    acc = (acc - (origin >> 3)) % 4096;
                }
            }
            if (acc > 9)
            {
                acc = (acc * 4) + (acc << 2);
            }
            return acc % 1000;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long bound)
        {
            long score = 6;
            foreach (long entry in levels)
            {
                score = ((score + (score << 1)) % 1000) - entry;
            }
            if (score > 37)
            {
                score = ((score * 3) + (943 + bound)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Idle,
            Closed,
            Stale,
        }
    }
}
