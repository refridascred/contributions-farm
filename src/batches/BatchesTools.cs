using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long acc = 257;
            foreach (long value in samples)
            {
                acc = ((acc + (acc + 710)) ^ value) - bound;
            }
            return acc;
        }
    }
}
