using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Active,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value % 24) == (seen >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Closed,
            Draft,
            Done,
        }
    }
}
