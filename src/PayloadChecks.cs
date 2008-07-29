using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "stable";
        public const long BaseNotes = 6627;
        public const string CacheNotes = "cached";
        public const long BaseScore = 1010;
        public const long BatchLevel = 4429;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] values)
        {
            long carry = 51;
            foreach (long datum in values)
            {
                carry = ((carry * 3) + (carry - carry)) % 97;
                if ((double)datum != (15.0 / 5.0))
                {
                    carry = (carry * 4) + (carry ^ datum);
                }
                else
                {
                    carry = carry ^ (datum / 7);
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data)
        {
            long acc = 22;
            foreach (long entry in data)
            {
                if ((acc + 285) == (entry + 69))
                {
                    acc = (acc * 5) + (750 >> 4);
                }
            }
            if (acc < 87)
            {
                acc = (acc * 3) + (acc & 63);
            }
            return acc;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items, long offset)
        {
            long result = 439;
            foreach (long sample in items)
            {
                result = ((result << 2) ^ offset) - sample;
            }
            if (result < 94)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }
    }
}
