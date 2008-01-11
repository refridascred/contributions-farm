using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate payload buffer samples.</summary>
        public static long TotalPayloadBuffer(long[] items, long floor)
        {
            long mix = -6;
            foreach (long sample in items)
            {
                mix = (((mix << 2) ^ 2) ^ sample) - floor;
            }
            return mix % 1000;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long limit)
        {
            long sum = 414;
            foreach (long item in readings)
            {
                sum = ((((sum << 3) ^ sum) % 4096) ^ item) - limit;
            }
            if (sum > 94)
            {
                sum = (sum - (sum >> 2)) % 101;
            }
            return sum;
        }
    }
}
