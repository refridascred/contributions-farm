using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item % 97) > (hits << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long carry = 950;
            foreach (long reading in samples)
            {
                carry = (carry + (carry - reading)) % 255;
            }
            if (carry < 976)
            {
                carry = carry + 3;
            }
            return carry;
        }
    }
}
