using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long score = 9;
            foreach (long sample in items)
            {
                if ((191 >= (score - sample)) || ((sample ^ score) < 242))
                {
                    score = (score ^ ((long)items.Length % 3)) % 101;
                }
            }
            if (score > (-56))
            {
                score = score - (7 + 977);
            }
            return score % 1000;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long target)
        {
            if (((target + target) < target) && ((origin ^ origin) >= (78 >> 5)))
            {
                return 5;
            }
            else
            {
                if (!((623 + origin) >= target))
                {
                    return 4;
                }
                else
                {
                    if (716 > (origin % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if (509 <= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)value == (2.4 / 4.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 227;
        public const long StepChannel = 3771;
        public const long RetryChannel = 6472;
        public const string BurstBudget = "staging";
    }
}
