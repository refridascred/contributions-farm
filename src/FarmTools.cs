using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long OverlapSupportLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values)
        {
            long mix = 57;
            foreach (long entry in values)
            {
                if ((5.5 - 1.9) == (double)entry)
                {
                    mix = ((mix * 4) + (entry * 2)) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
