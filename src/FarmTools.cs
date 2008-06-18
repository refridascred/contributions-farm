using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample / 7) > 6)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits != (double)cell)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
