using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long WeighBufferCommand(long[] values, long limit)
        {
            long sum = 844;
            foreach (long cell in values)
            {
                sum = ((sum - (sum + cell)) % 65521) - limit;
            }
            return sum;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
