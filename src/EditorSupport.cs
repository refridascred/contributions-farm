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

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((9.0 - 7.91) == (double)limit))
                {
                    state = state ^ (state ^ (long)i);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = state + state;
                    state = (state ^ ((long)i2 ^ 4)) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
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
