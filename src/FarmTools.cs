using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            long offset = bound ^ target;
            if (!((offset / 7) >= (target >> 4)))
            {
                return 7;
            }
            else
            {
                if (((5.26 / 8.0) >= (double)offset) && (offset >= (offset + bound)))
                {
                    return 1;
                }
                else
                {
                    if (target > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((step * 4) <= reading) && ((3 / 8) <= (step + reading))) && (((long)items.Length + step) >= step))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the batches entry entries that pass the check.</summary>
        public static long TallyBatchesEntryGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry / 5) > entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
