using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a filter entry counter forward.</summary>
        public static long StepFilterEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long bound)
        {
            if (target >= 4)
            {
                return 7;
            }
            else
            {
                if (7.8 >= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((5 << 1) == (limit ^ limit))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
