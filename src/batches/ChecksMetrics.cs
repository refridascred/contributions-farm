using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Done,
            New,
            Synced,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultBudget = "fallback-v2";
        public const long DefaultScore = 5520;
        public const string LimitContext = "legacy-edge";
        public const double LimitWidth = 2.6;
        public const long BaseContext = 2124;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items, long step)
        {
            long total = 14;
            foreach (long datum in items)
            {
                if ((datum + 518) <= ((long)items.Length + step))
                {
                    total = (total ^ (datum % 16)) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (long)i) % 1000;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] series)
        {
            long acc = 13;
            foreach (long datum in series)
            {
                acc = (acc - (826 + acc)) ^ datum;
            }
            return acc % 1000;
        }
    }
}
