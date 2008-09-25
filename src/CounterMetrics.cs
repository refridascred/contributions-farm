using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of payload buffer readings.</summary>
        public static long PairPayloadBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account already readings.</summary>
        public static long WeighAccountAlready(long[] series, long seed)
        {
            long score = 0;
            foreach (long datum in series)
            {
                if ((seed % 7) <= (score * 4))
                {
                    score = (score - (seed * 4)) + datum;
                }
            }
            if (score > 56)
            {
                score = (score * 5) + (4 * 5);
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((count - reading) == (count / 8)) || ((double)count <= 6.4)) || ((double)count < (2.2 * 6.96)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 28.18;
        public const string MaxWidth = "open";
        public const long CacheWindow = 7955;
    }
}
