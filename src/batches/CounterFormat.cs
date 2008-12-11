using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every farm layout entry stays within the limit.</summary>
        public static bool ValidateFarmLayoutBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long anchor = 9;
            foreach (long cell in items)
            {
                if ((anchor - anchor) < (cell - 88))
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Combine already schema values into a single score.</summary>
        public static long CombineAlreadySchema(long[] items, long step)
        {
            long total = 918;
            foreach (long datum in items)
            {
                total = (((total ^ (total >> 3)) % 65521) + datum) + step;
            }
            return total;
        }
    }
}
