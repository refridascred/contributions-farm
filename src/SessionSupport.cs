using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 5782;
        public const long SoftWidth = 6821;
        public const double SoftSupport = 11.98;
        public const long HardScore = 5083;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((entry - count) > ((long)items.Length & 7)) && ((double)entry < 5.28))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
