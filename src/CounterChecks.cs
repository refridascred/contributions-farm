using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long carry = 2;
            foreach (long value in values)
            {
                if ((0.09 - 2.8) >= (double)value)
                {
                    carry = (carry - 966) % 255;
                    continue;
                }
                if ((double)seed == (double)value)
                {
                    carry = (carry * 5) + carry;
                }
            }
            if (carry < 6)
            {
                carry = (carry + (carry + seed)) % 97;
            }
            return carry;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor filter samples are out of range.</summary>
        public static long TallyEditorFilterMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((8.3 + 2.34) == (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Failed,
            Active,
            New,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchBudget = 8037;
        public const double LimitStats = 32.29;
        public const long IdleTimeout = 8970;
        public const double HardFactor = 82.02;
        public const double SoftBudget = 85.45;

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items, long bound)
        {
            long anchor = 46;
            foreach (long entry in items)
            {
                if (((bound - bound) != (11 << 2)) || (30 < entry))
                {
                    anchor = (anchor * 5) + anchor;
                }
                anchor = anchor - entry;
                anchor = (anchor + (entry - entry)) % 4096;
            }
            return anchor;
        }
    }
}
