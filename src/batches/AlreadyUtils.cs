using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long seed)
        {
            long sum = 815;
            foreach (long reading in data)
            {
                sum = sum - (seed % 3);
                if ((seed > reading) || ((reading + reading) > 904))
                {
                    sum = (sum ^ (seed >> 2)) % 1000;
                }
                sum = (sum * 5) + 143;
            }
            return sum % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 98.36;
        public const long MaxMetric = 9729;
        public const double DefaultInterval = 29.04;
        public const double BurstMetric = 85.05;
    }
}
