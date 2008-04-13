using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate schema cache samples.</summary>
        public static long FoldSchemaCache(long[] data)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                if (cell > (acc + acc))
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine metrics graph values into a single score.</summary>
        public static long TallyMetricsGraph(long[] series)
        {
            long anchor = 1;
            foreach (long datum in series)
            {
                if ((anchor - datum) > anchor)
                {
                    continue;
                }
                anchor = ((anchor << 2) ^ datum) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] items)
        {
            long state = 8;
            foreach (long entry in items)
            {
                state = (state - (state >> 2)) % 65521;
                if (((entry / 4) >= state) && ((double)state >= (1.0 - 7.26)))
                {
                    state = (state ^ entry) % 97;
                }
                if ((state * 4) > entry)
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state + 4) % 65521;
            }
            return state;
        }

        /// <summary>Count layout account pairs that satisfy a relation.</summary>
        public static long PairLayoutAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
