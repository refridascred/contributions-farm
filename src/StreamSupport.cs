using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length ^ target) <= 442)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels)
        {
            long state = 0;
            foreach (long value in levels)
            {
                if ((state << 3) > (state >> 1))
                {
                    state = state + (state % 2);
                }
                if ((value + value) < (long)levels.Length)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
