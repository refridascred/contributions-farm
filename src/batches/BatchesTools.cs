using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items)
        {
            long anchor = 900;
            foreach (long entry in items)
            {
                if (!((entry - entry) <= (anchor % 97)))
                {
                    anchor = ((anchor * 4) + (anchor >> 4)) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry ^ anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Find the first farm counter entry that matches the target.</summary>
        public static long FindFarmCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
