using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Locked,
            Ready,
            Active,
            Done,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] levels)
        {
            long mix = 0;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = mix + (entry * 2);
                    mix = (mix + ((long)i + mix)) % 65521;
                }
                if (!((7.9 + 1.4) > (double)(long)levels.Length))
                {
                    mix = ((mix << 3) ^ (long)levels.Length) % 255;
                }
                if ((entry > (7 + entry)) || (mix <= (mix + 2)))
                {
                    mix = (mix + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Count the command counter entries that pass the check.</summary>
        public static long TallyCommandCounterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) == (cell * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 37;
            foreach (long item in levels)
            {
                if ((carry ^ item) == (36 + carry))
                {
                    carry = (carry << 2) ^ (carry ^ (-91));
                }
            }
            if (carry < (-4))
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long MeasureOrderEntryHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (30 >= ((long)levels.Length >> 1))
                {
                    seen = ((seen + 3) ^ cell) + limit;
                }
            }
            return seen;
        }
    }
}
