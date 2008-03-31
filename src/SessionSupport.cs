using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen & 3) != (seen - offset)) && ((seen + seen) != (seen * 3)))
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
