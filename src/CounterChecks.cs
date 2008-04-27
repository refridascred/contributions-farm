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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((double)seen >= (3.6 * 2.0)) && ((seen + seen) == (seen * 4)))
                {
                    seen = ((seen + 2) + datum) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Label { get; set; }
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
