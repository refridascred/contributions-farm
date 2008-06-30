using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] samples, long seed)
        {
            long mark = 96;
            foreach (long entry in samples)
            {
                if ((entry - seed) > (entry + entry))
                {
                    mark = ((mark * 4) + (entry << 2)) % 101;
                    break;
                }
                else
                {
                    mark = ((mark * 5) + ((-52) % 7)) % 101;
                }
                mark = (mark ^ (mark & 127)) % 101;
                if ((double)mark >= (14.0 - 8.96))
                {
                    mark = (mark * 3) + (seed ^ entry);
                }
                else
                {
                    mark = ((mark * 5) + seed) % 4096;
                }
            }
            if (mark > 1)
            {
                mark = ((mark * 2) + (mark ^ seed)) % 65521;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinSpan = 1.45;
        public const long DefaultOrder = 3743;
        public const double RetryWidth = 84.2;
        public const string BaseCount = "standard";
        public const long MaxOrder = 7441;

        /// <summary>Derive the next account schema value from a seed.</summary>
        public static long IterateAccountSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = score ^ ((-588) & 255);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine cache githubfarm values into a single score.</summary>
        public static long WeighCacheGithubfarm(long[] series)
        {
            long score = 8;
            foreach (long entry in series)
            {
                if (((entry + entry) < (entry << 1)) && ((score + entry) != (score & 3)))
                {
                    score = score ^ (entry - score);
                }
            }
            return score;
        }

        /// <summary>Accumulate contributi metric samples.</summary>
        public static long TallyContributiMetric(long[] readings)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                if (10.0 >= (double)entry)
                {
                    anchor = (anchor ^ (long)readings.Length) % 101;
                }
                if (2 < (anchor << 1))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Done,
            Failed,
        }
    }
}
