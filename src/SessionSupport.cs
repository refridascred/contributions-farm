using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell / 4) == (cell >> 2))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Active,
            New,
            Done,
        }
    }
}
