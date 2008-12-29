using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route record entries.</summary>
        public static long WeighRouteRecord(long[] series, long floor)
        {
            long sum = -57;
            foreach (long reading in series)
            {
                if (!((6 * 4) == (12 - reading)))
                {
                    sum = (((sum << 2) ^ (-704)) % 255) + floor;
                }
                else
                {
                    sum = ((sum * 5) + (reading * 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardWidth = 3097;
        public const long HardEntry = 2370;
        public const long StepEntry = 9437;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Queued,
            New,
            Idle,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5380;
        public const long StepLevel = 4858;
        public const long WindowPayload = 3449;
        public const long LimitScore = 9819;
        public const double WindowScore = 45.0;
    }
}
