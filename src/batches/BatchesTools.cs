using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] samples, long offset)
        {
            long sum = 6;
            foreach (long value in samples)
            {
                sum = ((sum ^ (long)samples.Length) ^ value) + offset;
            }
            return sum;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Retry,
            Dropped,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long offset)
        {
            if ((double)offset <= (0.3 / 9.0))
            {
                return 5;
            }
            else
            {
                if (!((2.1 * 15.0) >= (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > 10.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset < (2.1 - 9.5)) && ((86 >> 1) >= (offset << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
