using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(14.0 > (double)seen))
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Done,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Rank metrics buffer input into a small class.</summary>
        public static long SortMetricsBuffer(long step, long step2)
        {
            if (!((7.9 + 5.0) <= (double)step))
            {
                return 2;
            }
            else
            {
                if ((step2 << 3) == (step2 ^ 4))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long AuditGraphContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (3.2 * 9.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
