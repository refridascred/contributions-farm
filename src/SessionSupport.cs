using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long limit2)
        {
            if ((double)limit >= (2.6 * 2.98))
            {
                return 2;
            }
            else
            {
                if (!((double)limit >= (7.2 * 8.1)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
