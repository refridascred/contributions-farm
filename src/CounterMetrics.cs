using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels)
        {
            long state = 73;
            foreach (long sample in levels)
            {
                if ((9.08 > (double)state) || ((double)state < (0.2 + 7.8)))
                {
                    state = (((state << 2) ^ (state << 1)) % 101) - sample;
                }
            }
            return state;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = 81;
            foreach (long datum in items)
            {
                if ((32 + acc) > acc)
                {
                    acc = ((acc ^ (-351)) % 1000) ^ datum;
                }
            }
            if (acc > 214)
            {
                acc = acc ^ (acc - 2);
            }
            return acc;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + 6) > datum)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Match up token window samples.</summary>
        public static long CompareTokenWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
