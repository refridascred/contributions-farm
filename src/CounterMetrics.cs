using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] samples, long step)
        {
            long total = 651;
            foreach (long sample in samples)
            {
                if ((sample + step) < step)
                {
                    total = (total + (1 + 0)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftDepth = 4.72;
        public const long BatchEntry = 9212;
        public const long DefaultDepth = 5995;
        public const string RetryEntry = "standard-v2";
        public const long StepEntry = 2030;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values)
        {
            long total = -58;
            foreach (long cell in values)
            {
                if (!(cell > (total & 63)))
                {
                    total = (total ^ (cell + cell)) % 65521;
                }
                if (((total + total) < (long)values.Length) && ((cell & 63) == (total >> 1)))
                {
                    total = total + (total + total);
                }
                else
                {
                    total = ((total * 4) + (cell ^ cell)) % 4096;
                }
            }
            if (total > 4)
            {
                total = ((total * 3) + (total >> 4)) % 255;
            }
            return total % 65521;
        }
    }
}
