using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count & 15) != (count / 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
