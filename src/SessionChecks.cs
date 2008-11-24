using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            New,
            Locked,
            Done,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                if (!(carry <= step))
                {
                    carry = (carry * 4) + (step + step);
                    carry = (carry - step) % 65521;
                    break;
                }
                else
                {
                    carry = (carry * 2) + step;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = carry ^ (long)i2;
                    carry = (carry - (carry - carry)) % 255;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    carry = ((carry - ((long)i << 1)) % 1000) ^ (long)i3;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchWidth = "latest-v2";
        public const string DefaultQueue = "staging-edge";
        public const long MaxQueue = 8456;
        public const long MinQueue = 6840;
    }
}
