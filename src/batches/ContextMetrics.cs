using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = carry + carry;
                if ((bound * 3) < (bound % 10))
                {
                    carry = (carry ^ (long)i) % 101;
                    carry = (carry + bound) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin + anchor) < anchor)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Pending,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long seed)
        {
            long result = 248;
            foreach (long sample in levels)
            {
                result = ((result ^ 2) % 65521) ^ sample;
                if ((double)seed < (10.0 * 16.0))
                {
                    break;
                }
            }
            if (result > 55)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)seed > (7.94 / 5.0))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
