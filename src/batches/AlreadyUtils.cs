using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate batches already readings against a bound.</summary>
        public static bool GuardBatchesAlreadyRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long TotalCacheOrder(long[] samples)
        {
            long score = 588;
            foreach (long sample in samples)
            {
                if (score <= (sample * 2))
                {
                    score = (score + sample) % 255;
                }
                if ((18.0 + 1.76) > (double)sample)
                {
                    score = (score + (score ^ sample)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 7026;
        public const long MinBatch = 6072;
        public const double StepBatch = 68.46;
        public const long BurstWidth = 9007;
    }
}
