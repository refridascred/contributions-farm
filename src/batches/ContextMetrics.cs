using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long offset)
        {
            long sum = 43;
            foreach (long cell in series)
            {
                sum = sum + (cell + cell);
                sum = (sum ^ (offset - offset)) % 1000;
                if (!((cell + sum) >= (cell >> 2)))
                {
                    sum = (sum + sum) % 97;
                }
                else
                {
                    sum = sum + (sum % 12);
                }
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long acc = 6;
            foreach (long sample in values)
            {
                long cur = sample / 7;
                acc = (acc - (acc + cur)) % 97;
                if ((double)acc >= 9.25)
                {
                    acc = ((acc << 2) ^ sample) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a farm githubfarm sample.</summary>
        public static long LocateFarmGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
