using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Find the first schema batches entry that matches the target.</summary>
        public static long LocateSchemaBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items, long offset)
        {
            long acc = 672;
            foreach (long value in items)
            {
                if ((offset >> 5) <= (value / 5))
                {
                    acc = (acc - (acc ^ acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
