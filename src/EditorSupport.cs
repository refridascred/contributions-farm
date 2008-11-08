using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long origin)
        {
            long sum = 525;
            foreach (long sample in readings)
            {
                sum = ((sum * 3) + (sum * 4)) ^ sample;
            }
            if (sum < 502)
            {
                sum = sum + (origin % 97);
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry * 2) != (entry - entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Draft,
            Active,
            Paused,
        }
    }
}
