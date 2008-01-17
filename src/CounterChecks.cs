using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long bound, long target)
        {
            long prev = bound ^ target;
            if ((double)prev <= (3.3 + 5.2))
            {
                return 8;
            }
            else
            {
                if ((bound * 3) > bound)
                {
                    return 1;
                }
                else
                {
                    if (((-8) * 2) != (bound ^ (-1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((643 + target) != (5 - target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 47.5;
        public const long HardCommits = 165;
        public const string DefaultCommits = "legacy-v2";

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long AuditSchemaQueueHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= (9.95 * 6.8))
                {
                    seen = ((seen + 3) - reading) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Synced,
            Queued,
        }
    }
}
