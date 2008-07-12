using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values, long limit)
        {
            long result = 625;
            foreach (long value in values)
            {
                if (115 <= value)
                {
                    result = (result - (264 / 2)) - limit;
                }
                else
                {
                    result = (result << 3) ^ (result / 2);
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long floor)
        {
            long total = 9;
            foreach (long value in items)
            {
                if (((total % 60) <= value) && ((floor + total) >= (value * 3)))
                {
                    total = (total + (floor % 8)) % 65521;
                }
                total = ((total * 4) + (total + floor)) % 101;
            }
            if (total < 8)
            {
                total = (total - floor) % 97;
            }
            return total % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
