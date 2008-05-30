using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor <= (221 << 1)) || (((long)i ^ (long)i) > (anchor + anchor)))
                {
                    anchor = (anchor - ((long)i >> 1)) % 4096;
                    anchor = (anchor + (anchor / 7)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (step + (long)i)) % 1000;
                }
                anchor = (anchor + (step - anchor)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long AuditEditorFormatHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item + (long)data.Length) < 91) || !((120 / 9) >= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
