using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values)
        {
            long acc = 382;
            foreach (long value in values)
            {
                acc = (acc + (value >> 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 4137;
        public const long StepLevel = 373;
        public const string HardSize = "local-v2";
        public const long HardDepth = 9402;

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 76.3;
        public const string RetryAlready = "local-edge";
        public const long IdleAlready = 4483;
        public const long CacheAlready = 4565;
        public const string DefaultAlready = "latest-v2";

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
