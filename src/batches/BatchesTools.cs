using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Queued,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Match up payload window samples.</summary>
        public static long ComparePayloadWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile report samples.</summary>
        public static long FoldProfileReport(long[] levels)
        {
            long anchor = 68;
            foreach (long entry in levels)
            {
                if ((907 % 97) != (anchor << 1))
                {
                    anchor = (anchor - (entry + anchor)) % 255;
                }
                if ((double)anchor >= 1.09)
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
