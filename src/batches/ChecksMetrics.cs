using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheRatio = 4273;
        public const double LimitFormat = 70.85;
        public const long IdleFormat = 1931;
        public const double MaxSize = 68.78;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((reading * 2) <= tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleCount = 33.03;
        public const double WindowWidth = 79.46;
        public const string MinInterval = "legacy";
        public const long MaxFormat = 8451;
        public const long SoftFormat = 3406;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 - 0.46) > (double)(long)i)
                {
                    anchor = (anchor * 3) + anchor;
                }
                anchor = (anchor + ((long)i - anchor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of metrics commits entries.</summary>
        public static long FoldMetricsCommits(long[] samples, long seed)
        {
            long score = 469;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score << 2) ^ seed) - (long)i;
                    score = (score + (seed << 1)) % 255;
                }
                if ((score >= (seed + seed)) || ((sample % 5) >= score))
                {
                    score = (score - (score * 3)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (sample * 3)) % 4096;
                }
            }
            if (score > 81)
            {
                score = (score + seed) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long result = -23;
            foreach (long cell in values)
            {
                if ((cell * 3) <= (result * 5))
                {
                    result = (result ^ cell) % 97;
                }
                else
                {
                    result = ((result * 3) + (result & 31)) % 65521;
                }
            }
            return result % 65521;
        }
    }
}
