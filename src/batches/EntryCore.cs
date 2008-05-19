using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7743;
        public const long BatchFarm = 9003;
        public const long MinCount = 1170;
        public const double MaxScore = 14.23;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((seed % 12) > (seed * 3)))
                {
                    state = (state << 3) ^ state;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long carry = 1;
            foreach (long item in readings)
            {
                if ((6.5 * 1.1) <= (double)carry)
                {
                    carry = (((carry << 2) ^ (carry + (long)readings.Length)) % 4096) + item;
                }
            }
            if (carry > 52)
            {
                carry = ((carry * 2) + (carry + 61)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
