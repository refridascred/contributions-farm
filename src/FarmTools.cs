using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the graph record entries that pass the check.</summary>
        public static long AuditGraphRecordOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum * 4) >= (datum % 2)) && ((4.9 * 15.0) <= (double)matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count editor format pairs that satisfy a relation.</summary>
        public static long PairEditorFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples, long origin)
        {
            long carry = 200;
            foreach (long entry in samples)
            {
                carry = ((carry ^ (origin - 7)) % 97) - entry;
            }
            return carry % 97;
        }
    }
}
