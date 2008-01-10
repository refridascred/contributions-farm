using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if ((double)item > (6.35 * 5.3))
                {
                    total = (total - (item + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - target) < (carry & 31))
                {
                    carry = (carry + carry) % 255;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long state = 867;
            foreach (long sample in values)
            {
                if ((double)sample < (8.54 / 9.0))
                {
                    state = state + sample;
                }
                else
                {
                    state = (state + (sample & 7)) % 97;
                }
            }
            if (state < 48)
            {
                state = (state - state) % 1000;
            }
            return state;
        }
    }
}
