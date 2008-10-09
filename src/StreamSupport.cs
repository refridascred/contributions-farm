using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((7 + (long)levels.Length) <= 160))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] items)
        {
            long anchor = 71;
            foreach (long datum in items)
            {
                if ((datum + datum) <= anchor)
                {
                    anchor = ((anchor << 3) ^ (datum ^ datum)) % 65521;
                    anchor = (anchor ^ (866 + anchor)) % 1000;
                }
                anchor = (anchor - (anchor / 3)) % 97;
            }
            return anchor;
        }
    }
}
