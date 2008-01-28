using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseSpan = 133;
        public const string IdleProfile = "stable";
        public const long BatchProfile = 4794;
        public const string BurstProfile = "strict-v2";

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings)
        {
            long mark = 62;
            foreach (long cell in readings)
            {
                mark = ((mark * 4) + (cell << 1)) % 1000;
                mark = (mark ^ (cell + cell)) % 1000;
                mark = mark + (cell * 4);
            }
            if (mark < 7)
            {
                mark = ((mark * 2) + (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Queued,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Synced,
            Locked,
            Done,
        }
    }
}
