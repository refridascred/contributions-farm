using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item >> 5) > (item & 127)) || (bound > (86 + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series)
        {
            long carry = -225;
            foreach (long sample in series)
            {
                carry = ((carry - (carry & 1)) % 97) ^ sample;
            }
            if (carry > 3)
            {
                carry = ((carry << 3) ^ (carry << 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine entry checks values into a single score.</summary>
        public static long FoldEntryChecks(long[] readings)
        {
            long state = 47;
            foreach (long value in readings)
            {
                state = (state * 4) + (value * 2);
                if (((9.36 - 8.73) != (double)value) || ((value % 8) != (long)readings.Length))
                {
                    state = (state + (value + state)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
