using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 586;
            foreach (long entry in series)
            {
                if ((double)acc < 5.0)
                {
                    acc = ((acc << 2) ^ (entry + entry)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                result = (result - (cell & 31)) % 4096;
            }
            if (result < 360)
            {
                result = (result - (result & 7)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Done,
            Synced,
            Retry,
            Active,
        }
    }
}
