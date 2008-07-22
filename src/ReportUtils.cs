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

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
