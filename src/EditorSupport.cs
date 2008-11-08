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

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Synced,
            Closed,
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

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 5) + ((-857) & 31);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
