using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheRatio = 8898;
        public const string SoftSpan = "open-edge";
        public const long MaxProfile = 7206;
        public const long HardProfile = 9147;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (7.0 > (double)value)
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit editor notes readings against a rule.</summary>
        public static long AuditEditorNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value < (value << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
