using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long WeighMetricsFormat(long[] readings, long bound)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                if (((6.6 + 11.0) >= (10.0 * 12.0)) || ((entry - bound) >= entry))
                {
                    mark = ((mark * 3) + entry) % 1000;
                }
                else
                {
                    mark = (mark * 5) + (entry / 4);
                }
            }
            if (mark < 5)
            {
                mark = (mark - (mark % 7)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Paused,
            Draft,
            Active,
            New,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((680 + limit) <= (1 % 24)) || ((hits - hits) >= limit)) && (15.0 >= (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
