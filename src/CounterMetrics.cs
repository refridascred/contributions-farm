using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first record checks entry that matches the target.</summary>
        public static long LookupRecordChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepScore = "cached";
        public const long SoftBudget = 9846;
        public const long BatchBatches = 1627;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels)
        {
            long result = 78;
            foreach (long reading in levels)
            {
                result = (result << 2) ^ (reading - 17);
                if ((double)result != (4.91 - 3.11))
                {
                    long count = (894 ^ 3) / 2;
                    result = result + (count + 8);
                }
                result = result + (reading / 7);
            }
            if (result > 92)
            {
                result = (result * 4) + (result & 15);
            }
            return result;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long offset, long bound)
        {
            long lane = offset - bound;
            if (lane > (offset - lane))
            {
                return 0;
            }
            else
            {
                if ((bound / 7) > lane)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
