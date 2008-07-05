using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] levels, long seed)
        {
            long acc = 21;
            foreach (long sample in levels)
            {
                if (((3.56 - 0.51) >= (double)acc) && (44 >= (acc << 2)))
                {
                    acc = (acc << 3) ^ (acc - 4);
                }
                if (seed >= (seed * 4))
                {
                    acc = (acc - sample) % 4096;
                }
                else
                {
                    acc = (acc ^ (seed >> 1)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleRatio = "fallback";
        public const long BatchQueue = 9764;
        public const string BatchBudget = "standard";
        public const string SoftBudget = "stable-edge";
        public const long MinQueue = 1754;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long target, long step)
        {
            long prev = target ^ step;
            if ((double)step == (5.67 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((prev << 1) < (prev << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((step ^ target) <= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
