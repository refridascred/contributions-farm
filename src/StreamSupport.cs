using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
