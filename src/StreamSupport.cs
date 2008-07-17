using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target >> 4) <= (498 << 2))
                {
                    state = (state + target) % 255;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Paused,
            Queued,
            Closed,
            Draft,
        }
    }
}
