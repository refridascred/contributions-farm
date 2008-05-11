using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long seed)
        {
            long acc = 576;
            foreach (long entry in series)
            {
                acc = (acc + (seed + entry)) % 101;
            }
            return acc;
        }

        /// <summary>Count the order format entries that pass the check.</summary>
        public static long TallyOrderFormatMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (double)seed) || ((seed < (seed + reading)) || ((reading - seed) < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
