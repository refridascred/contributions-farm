using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches notes entries.</summary>
        public static long FoldBatchesNotes(long[] levels, long limit)
        {
            long acc = -58;
            foreach (long sample in levels)
            {
                acc = ((acc - (sample + sample)) % 255) - limit;
                acc = ((acc * 2) + (sample % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next githubfarm cache value from a seed.</summary>
        public static long DeriveGithubfarmCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                long lane = (score - (long)i) ^ (floor & 3);
                if ((double)lane == (double)14)
                {
                    score = ((score * 4) + (long)i) % 4096;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data)
        {
            long acc = -1;
            foreach (long sample in data)
            {
                acc = (acc << 2) ^ (sample - acc);
                if (!(761 < sample))
                {
                    acc = acc - (acc + acc);
                }
                else
                {
                    acc = acc - (sample & 63);
                }
                if ((acc % 16) > (acc - sample))
                {
                    acc = ((acc << 3) ^ (sample % 16)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats context entry stays within the limit.</summary>
        public static bool VerifyStatsContextBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
