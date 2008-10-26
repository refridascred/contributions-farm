using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!(offset > (result + (long)i)))
                {
                    result = (result + (113 & 63)) % 101;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Ready,
            Failed,
            Synced,
            New,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
