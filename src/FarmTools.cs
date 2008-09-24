using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit queue format readings against a rule.</summary>
        public static long AuditQueueFormatHits(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + count) == (64 - (long)data.Length))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series, long bound)
        {
            long mix = 5;
            foreach (long entry in series)
            {
                if ((0 * 3) > bound)
                {
                    mix = ((mix * 4) + (entry - bound)) % 65521;
                }
            }
            if (mix < 312)
            {
                mix = (mix ^ (604 / 3)) % 97;
            }
            return mix;
        }
    }
}
