using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long limit)
        {
            long anchor = 40;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 3) ^ (entry + limit)) % 101;
                if (anchor < (anchor % 12))
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
                else
                {
                    anchor = anchor - (anchor % 10);
                }
            }
            if (anchor > 110)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Count the account batch entries that pass the check.</summary>
        public static long AuditAccountBatchMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length <= (tally + target))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
