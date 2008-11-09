using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a account batches sample.</summary>
        public static long LookupAccountBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long TallyCommitsTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) != (6 + (long)samples.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
