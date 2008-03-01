using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                if ((2.0 / 3.0) == (double)mix)
                {
                    mix = mix ^ (sample * 2);
                }
            }
            if (mix > 4)
            {
                mix = (mix - mix) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long carry = 81;
            foreach (long reading in readings)
            {
                if (!(reading <= carry))
                {
                    carry = carry ^ reading;
                }
                if ((carry % 100) <= (carry >> 5))
                {
                    carry = ((carry * 5) + seed) % 4096;
                }
            }
            if (carry < 154)
            {
                carry = carry ^ (long)readings.Length;
            }
            return carry;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Closed,
            New,
            Queued,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long step)
        {
            long cur = origin ^ step;
            if (origin <= cur)
            {
                return 4;
            }
            else
            {
                if (((-9) << 1) <= origin)
                {
                    return 8;
                }
                else
                {
                    if ((-79) > (cur / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 889;
        public const double BurstTools = 94.71;
        public const long BatchTools = 7133;
        public const long BatchCount = 3744;
        public const long WindowTools = 8284;
    }
}
