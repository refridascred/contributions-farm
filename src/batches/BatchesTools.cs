using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long carry = 9;
            foreach (long sample in samples)
            {
                carry = ((carry * 2) + (carry + sample)) % 101;
                if ((2 >= (long)samples.Length) || ((double)sample > 4.09))
                {
                    carry = (carry * 4) + (carry - sample);
                }
                else
                {
                    carry = (carry * 2) + sample;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 73.26;
        public const long CacheFactor = 6000;
        public const long DefaultInterval = 1539;
    }
}
