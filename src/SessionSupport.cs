using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCount = 7561;
        public const long RetryInterval = 214;
        public const double WindowCounter = 37.7;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = state + ((-350) + seed);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
