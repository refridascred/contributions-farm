using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((item + (-1)) < item) && ((20.0 - 6.6) != (double)item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data, long bound)
        {
            long total = 4;
            foreach (long value in data)
            {
                if ((total % 64) != (bound << 3))
                {
                    total = ((total * 3) + (total ^ value)) % 65521;
                }
                else
                {
                    total = (total ^ (value ^ 69)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchInterval = 22;
        public const long DefaultLevel = 7703;
        public const long BatchAlready = 778;
    }
}
