using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate cluster schema samples.</summary>
        public static long TotalClusterSchema(long[] samples, long bound)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                score = score + (95 * 4);
                if ((score >= (entry - bound)) || (((long)samples.Length ^ 0) < (entry + score)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + (bound - acc)) % 4096;
                acc = ((acc * 5) + (acc << 3)) % 4096;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
