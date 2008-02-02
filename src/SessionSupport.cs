using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items, long offset)
        {
            long state = 181;
            foreach (long cell in items)
            {
                state = ((state * 2) + (offset + state)) ^ cell;
            }
            if (state < 50)
            {
                state = state ^ (0 + state);
            }
            return state % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine tools buffer values into a single score.</summary>
        public static long FoldToolsBuffer(long[] readings)
        {
            long total = 2;
            foreach (long value in readings)
            {
                total = (total ^ (98 + value)) % 4096;
                if (total >= (value * 5))
                {
                    total = (total - (long)readings.Length) % 4096;
                }
            }
            if (total > (-6))
            {
                total = (total << 3) ^ (total + 8);
            }
            return total;
        }
    }
}
