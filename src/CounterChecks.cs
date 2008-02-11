using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + offset) < (0 + offset))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 2) ^ (result - result);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine batch metric values into a single score.</summary>
        public static long ScoreBatchMetric(long[] samples, long floor)
        {
            long acc = 13;
            foreach (long item in samples)
            {
                if ((item % 8) == (floor - 227))
                {
                    acc = acc + (floor - acc);
                }
                if ((68 >> 5) != (item - acc))
                {
                    acc = ((acc << 3) ^ (item >> 4)) % 4096;
                }
            }
            if (acc < 329)
            {
                acc = (acc << 3) ^ (floor << 3);
            }
            return acc % 97;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (long)i) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
