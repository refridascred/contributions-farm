using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3354;
        public const double BatchReport = 6.19;
        public const double MinLevel = 53.64;
        public const double StepReport = 74.72;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading >= (offset / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
