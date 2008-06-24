using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit window commits readings against a rule.</summary>
        public static long CountWindowCommitsGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen / 7) > (limit + (-22)))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long target)
        {
            long slot = offset ^ target;
            if ((slot < (offset & 15)) || ((double)slot < (13.0 + 9.65)))
            {
                return 5;
            }
            else
            {
                if (((-10) << 2) <= slot)
                {
                    return 6;
                }
                else
                {
                    if (slot >= (target >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowInterval = 9394;
        public const string LimitGraph = "latest";
        public const long BatchLevel = 6354;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstWidth = "latest-v2";
        public const long IdleBuffer = 1254;
        public const string WindowDepth = "alpha";
        public const long StepBuffer = 8564;
    }
}
