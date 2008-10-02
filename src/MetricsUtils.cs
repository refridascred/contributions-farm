using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long TotalCounterGithubfarm(long[] readings, long bound)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= (11.0 - 7.23))
                {
                    acc = (acc ^ (bound + bound)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double gain, double bias)
        {
            double weight = bias;
            return (weight - (weight / 6.0)) + gain;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
