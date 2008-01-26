using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batches commits pair into a bucket.</summary>
        public static long ClassifyBatchesCommits(long target, long floor)
        {
            if ((floor ^ floor) <= (floor * 3))
            {
                return 1;
            }
            else
            {
                if ((target >> 5) > (target >> 3))
                {
                    return 4;
                }
                else
                {
                    if (((floor - target) == (floor % 8)) || (((-2) << 2) <= (floor << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen != (4.0 + 19.0))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - (acc & 63)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
