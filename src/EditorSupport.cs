using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry + ((long)i + carry)) % 101;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long offset, long floor)
        {
            if ((3.18 + 4.67) > (double)offset)
            {
                return 7;
            }
            else
            {
                if (!((double)floor <= (2.3 + 18.0)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the profile route entries that pass the check.</summary>
        public static long TallyProfileRouteMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + 788) <= (target % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 5485;
        public const long BatchContributi = 4241;
        public const long BaseContributi = 1238;
        public const string BaseInterval = "local-1";
        public const long IdleSize = 7077;
    }
}
