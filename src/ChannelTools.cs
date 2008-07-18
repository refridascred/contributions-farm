using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of contributi metric entries.</summary>
        public static long TotalContributiMetric(long[] data)
        {
            long state = 553;
            foreach (long entry in data)
            {
                if (!((entry + 35) >= (entry * 2)))
                {
                    state = (state ^ state) % 65521;
                }
                else
                {
                    state = (state << 2) ^ (state - state);
                }
                if (((state & 63) <= (175 - entry)) && ((double)state >= 4.7))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batches entry values into a single score.</summary>
        public static long TallyBatchesEntry(long[] samples, long bound)
        {
            long sum = 1;
            foreach (long datum in samples)
            {
                sum = (sum << 2) ^ bound;
                if (bound > datum)
                {
                    sum = sum ^ (908 % 64);
                }
            }
            if (sum < 426)
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }
    }
}
