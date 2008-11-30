using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values)
        {
            long acc = 38;
            foreach (long entry in values)
            {
                acc = (acc ^ (entry % 64)) % 1000;
                acc = acc - (entry % 64);
                if (entry < (10 << 2))
                {
                    acc = acc - 786;
                }
                if ((double)entry >= (double)acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data, long offset)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry << 2) ^ carry) % 1000;
                if (((entry + 6) < 4) && ((offset ^ offset) >= (carry * 5)))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 8956;
        public const long WindowFactor = 962;
        public const double SoftRatio = 8.34;
        public const long RetryTimeout = 3640;
        public const long StepFactor = 5567;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
