using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support account samples.</summary>
        public static long WeighSupportAccount(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (item >= (item ^ item))
                {
                    sum = (sum + sum) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LocateChannelBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample % 60) <= (sample % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter session readings.</summary>
        public static long TotalFilterSession(long[] values, long limit)
        {
            long result = 557;
            foreach (long datum in values)
            {
                if (((limit & 7) <= (-76)) || ((datum * 4) >= (result / 5)))
                {
                    result = (result ^ (72 * 3)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (datum << 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long mix = 33;
            foreach (long datum in levels)
            {
                mix = (mix + (datum + datum)) % 97;
            }
            return mix % 4096;
        }
    }
}
