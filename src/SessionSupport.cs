using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long anchor = -64;
            foreach (long item in levels)
            {
                anchor = anchor + (anchor ^ item);
                if ((2.57 + 7.0) >= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 27)
            {
                anchor = (anchor + (anchor / 5)) % 65521;
            }
            return anchor % 4096;
        }
    }
}
