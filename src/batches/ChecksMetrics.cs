using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long offset)
        {
            long mark = 84;
            foreach (long sample in values)
            {
                mark = (((mark - (1 / 4)) % 1000) + sample) - offset;
            }
            if (mark > 0)
            {
                mark = ((mark << 3) ^ (mark * 2)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Count { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardDepth = 6211;
        public const long BatchFilter = 9013;
        public const long MaxFactor = 9136;
        public const long DefaultFilter = 5236;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((count & 63) < ((long)items.Length & 3)) && !((reading + reading) > reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Check that every token githubfarm entry stays within the limit.</summary>
        public static bool CheckTokenGithubfarmLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
