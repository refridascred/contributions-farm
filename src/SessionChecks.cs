using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count command notes pairs that satisfy a relation.</summary>
        public static long OverlapCommandNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm contributi readings against a rule.</summary>
        public static long AuditGithubfarmContributiHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)target > (7.59 / 5.0))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 220;
        public const string CacheSize = "strict-1";
        public const string WindowSpan = "staging-1";
        public const long CacheCounter = 1726;
        public const string RetryCounter = "primary-1";

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
