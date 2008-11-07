using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((origin ^ tally) > origin)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long SeriesQueueContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ 43) % 4096;
                carry = ((carry * 5) + (limit - carry)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading / 7) >= target)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
