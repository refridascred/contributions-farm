using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long seed)
        {
            if (((double)seed <= (double)43) && ((4.0 / 9.0) <= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((double)seed < (1.0 * 12.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of buffer githubfarm entries.</summary>
        public static long CombineBufferGithubfarm(long[] samples)
        {
            long acc = 9;
            foreach (long reading in samples)
            {
                if ((1.0 / 5.0) > (double)acc)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = acc - (reading >> 4);
                }
            }
            if (acc < 456)
            {
                acc = (acc - (acc ^ 6)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length / 7) > sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 76.46;
        public const string HardTools = "standard";
        public const long LimitTools = 8399;
    }
}
