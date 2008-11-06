using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) <= (seen << 3)) && (8.0 > (double)seen)) || (((datum * 3) <= seen) && (seen > (1 + 9))))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Draft,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Combine contributi metrics values into a single score.</summary>
        public static long ScoreContributiMetrics(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length + mix) != (sample + 421)) || ((5 % 100) <= (mix - sample)))
                {
                    mix = (mix - mix) % 255;
                }
                mix = mix - (mix / 8);
            }
            return mix % 65521;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
