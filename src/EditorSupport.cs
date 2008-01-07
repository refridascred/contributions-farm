using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "strict-edge";
        public const long DefaultNotes = 7101;
        public const long StepFactor = 8725;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Stale,
            New,
            Draft,
            Paused,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum - ((long)i % 64)) % 65521;
                sum = (sum * 4) + 53;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Ready,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long state = -8;
            foreach (long reading in samples)
            {
                if ((double)state != (double)reading)
                {
                    state = (state - (6 % 8)) % 97;
                }
            }
            if (state > 735)
            {
                state = ((state * 5) + (state / 7)) % 101;
            }
            return state;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
