using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Locked,
            Synced,
            Failed,
            Active,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen % 10) >= (datum + seen)) || (((seen * 3) <= 5) || ((seen & 63) > datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
