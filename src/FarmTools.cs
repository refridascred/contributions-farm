using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ (-517)) % 101;
                result = result - (result / 7);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the order command entries that pass the check.</summary>
        public static long MeasureOrderCommandHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (1.64 <= (double)datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
