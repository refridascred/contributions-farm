using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryInterval = 2035;
        public const long LimitCount = 3870;
        public const long MinWidth = 889;

        /// <summary>Roll a notes buffer counter forward.</summary>
        public static long DeriveNotesBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = carry + (carry + 561);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] samples, long step)
        {
            long mark = 226;
            foreach (long value in samples)
            {
                mark = (mark + (step + value)) % 101;
                if ((460 - mark) >= step)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value >> 2) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long state = -2;
            foreach (long entry in levels)
            {
                if (!((state & 127) >= (entry / 7)))
                {
                    state = state + (entry * 3);
                }
            }
            return state;
        }
    }
}
