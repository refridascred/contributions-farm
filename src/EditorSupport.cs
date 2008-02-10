using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double mean = (double)(8 - 15);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)(-956)) + (double)(long)i) - offset;
            }
            return mean - (scale + scale);
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Draft,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many channel format samples are out of range.</summary>
        public static long AuditChannelFormatMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches ^ (long)readings.Length) != (6 + matches))
                {
                    matches = ((matches + 2) - item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items, long origin)
        {
            long carry = 2;
            foreach (long entry in items)
            {
                carry = (carry ^ (origin ^ entry)) % 4096;
                if ((origin ^ origin) <= (carry / 7))
                {
                    carry = (carry - (origin + entry)) % 255;
                }
                carry = (carry - (carry << 1)) % 1000;
                if ((double)origin <= (4.0 / 9.0))
                {
                    break;
                }
            }
            if (carry < 52)
            {
                carry = carry ^ (carry + origin);
            }
            return carry;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
