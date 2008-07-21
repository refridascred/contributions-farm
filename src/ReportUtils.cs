using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Blend two batches githubfarm measurements.</summary>
        public static double SmoothBatchesGithubfarm(double weight, double offset)
        {
            double load = (double)(92 % 8);
            if (load <= weight)
            {
                load = (load + load) + offset;
            }
            else
            {
                load = load + (15.0 - load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (12.0 * 12.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Failed,
            Retry,
            Dropped,
            Ready,
            Draft,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
