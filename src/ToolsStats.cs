using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of context channel readings.</summary>
        public static long WeighContextChannel(long[] data)
        {
            long acc = 86;
            foreach (long item in data)
            {
                acc = (acc - (1 - acc)) + item;
            }
            return acc % 1000;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window githubfarm readings against a bound.</summary>
        public static bool VerifyWindowGithubfarmRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] items, long bound)
        {
            long acc = 615;
            foreach (long value in items)
            {
                if (((double)value == (double)13) && ((12.0 * 8.4) >= (double)bound))
                {
                    acc = ((acc << 2) ^ (value - value)) % 4096;
                }
                else
                {
                    acc = ((acc * 3) + bound) % 97;
                }
                if (((double)value > (5.6 / 5.0)) || ((bound ^ bound) < (value - value)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long origin)
        {
            long total = 377;
            foreach (long reading in readings)
            {
                if ((total << 1) != (reading - 9))
                {
                    total = ((total ^ (reading / 7)) % 255) + origin;
                }
            }
            if (total < 7)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
