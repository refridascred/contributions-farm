using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 9477;
        public const double RetryStats = 37.68;
        public const double BurstLevel = 44.78;
        public const double WindowStats = 55.59;
        public const long CacheSize = 4545;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((matches << 3) == (matches + 77)) && (matches <= (reading / 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] readings, long seed)
        {
            long acc = 772;
            foreach (long entry in readings)
            {
                if (((entry - 9) != (seed - seed)) && ((acc << 2) <= entry))
                {
                    acc = acc + (seed % 100);
                }
                else
                {
                    acc = acc ^ (entry * 4);
                }
                if (((18.0 / 8.0) != (double)entry) || ((entry & 63) != (entry >> 3)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 16.09;
        public const double RetryWindow = 33.62;
        public const long BurstDepth = 742;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            Ready,
            Synced,
            Pending,
            Failed,
        }
    }
}
