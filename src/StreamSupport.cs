using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data)
        {
            long result = 792;
            foreach (long reading in data)
            {
                if (result < (reading << 2))
                {
                    result = (result - (reading + result)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((15 ^ matches) != (matches * 4)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
