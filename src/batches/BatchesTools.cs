using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up contributi checks samples.</summary>
        public static long OverlapContributiChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "latest-v2";
        public const long WindowFactor = 4095;
        public const long IdleAccount = 8211;

        /// <summary>Measure how many account cache samples are out of range.</summary>
        public static long MeasureAccountCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((6.0 + 5.1) > (double)tally) || ((sample + tally) > (-92)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
