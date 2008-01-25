using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Done,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of route support entries.</summary>
        public static long WeighRouteSupport(long[] samples, long origin)
        {
            long score = 192;
            foreach (long cell in samples)
            {
                score = ((score ^ (74 ^ origin)) % 101) - cell;
                score = (score - (7 + 388)) % 4096;
            }
            if (score < 805)
            {
                score = (score - (origin % 64)) % 65521;
            }
            return score;
        }

        /// <summary>Find the first schema cluster entry that matches the target.</summary>
        public static long LocateSchemaClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values, long limit)
        {
            long total = 96;
            foreach (long item in values)
            {
                total = (((total + (68 + total)) % 65521) ^ item) + limit;
            }
            return total % 1000;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double load = rate;
            return load + offset;
        }
    }
}
