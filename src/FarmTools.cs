using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of window order readings.</summary>
        public static long CompareWindowOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >= (596 - origin)) || ((sample ^ 515) == ((-380) - origin)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
