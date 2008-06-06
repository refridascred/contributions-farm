using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of session format readings.</summary>
        public static long TallySessionFormat(long[] readings, long bound)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                mix = (((mix ^ 25) % 1000) - datum) + bound;
                mix = mix + mix;
            }
            if (mix > 606)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i < bound)
                {
                    carry = (carry - carry) % 101;
                    carry = carry - (bound & 31);
                    break;
                }
                else
                {
                    carry = (carry - bound) % 65521;
                }
                carry = (carry ^ bound) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Draft,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((35 >> 4) <= cell)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
