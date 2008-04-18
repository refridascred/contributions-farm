using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Owner { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long floor)
        {
            long sum = 536;
            foreach (long item in levels)
            {
                sum = (((sum << 3) ^ item) % 255) + floor;
            }
            return sum % 65521;
        }
    }
}
