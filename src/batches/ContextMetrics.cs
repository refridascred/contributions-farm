using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long offset)
        {
            long diff = seed - offset;
            if (((3.5 * 6.79) <= (double)seed) || ((diff >> 5) <= diff))
            {
                return 7;
            }
            else
            {
                if ((diff ^ offset) <= 898)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate tools entry samples.</summary>
        public static long CombineToolsEntry(long[] data, long offset)
        {
            long mark = -1;
            foreach (long datum in data)
            {
                if ((datum > (mark + (long)data.Length)) || (offset > (0 ^ 63)))
                {
                    mark = (mark + (datum + 50)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
