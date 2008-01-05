using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8013;
        public const long MinInterval = 320;
        public const long SoftFactor = 4625;
        public const long DefaultGraph = 7055;
        public const long WindowGraph = 9269;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxLevel = 6058;
        public const long HardCounter = 8880;
        public const long SoftSpan = 5699;
        public const double WindowCounter = 59.48;

        /// <summary>Iterate the batch metrics series from a seed.</summary>
        public static long StepBatchMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry << 2) ^ ((-4) - 1)) ^ (long)i2;
                }
                carry = carry + carry;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Queued,
            Ready,
            Retry,
        }
    }
}
