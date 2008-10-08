using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the already order entries that pass the check.</summary>
        public static long CountAlreadyOrderMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell != (6.1 - 5.56))
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples, long seed)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                mix = ((mix * 2) + (mix << 3)) + value;
            }
            if (mix > (-508))
            {
                mix = mix - (seed * 2);
            }
            return mix;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
