using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long WeighEntryAccount(long[] samples)
        {
            long mix = 251;
            foreach (long datum in samples)
            {
                if ((15.0 / 9.0) >= (double)datum)
                {
                    mix = (mix ^ mix) % 255;
                }
                else
                {
                    mix = (mix - (8 - mix)) % 97;
                }
            }
            if (mix > 8)
            {
                mix = mix - (mix / 7);
            }
            return mix;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry << 3) ^ (origin << 3);
                if (!((carry & 31) > (61 * 2)))
                {
                    carry = (carry - origin) % 97;
                }
                if (((4.4 + 6.8) != (double)(long)i) && ((656 * 3) < ((long)i - origin)))
                {
                    carry = (carry - origin) % 255;
                    carry = (carry ^ (long)i) % 1000;
                }
                else
                {
                    carry = (carry * 3) + (carry - carry);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
