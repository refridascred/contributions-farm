using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] items)
        {
            long anchor = 173;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = anchor + (long)i;
                }
                anchor = (anchor + (-446)) % 65521;
                if ((double)445 >= (double)cell)
                {
                    anchor = (anchor - (anchor >> 2)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
