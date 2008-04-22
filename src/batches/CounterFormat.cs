using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultFactor = 3885;
        public const long HardSchema = 5896;
        public const long WindowCount = 883;
        public const double DefaultRatio = 54.7;
        public const long MaxSchema = 3729;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7.69 - 3.67) != (double)hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }
    }
}
