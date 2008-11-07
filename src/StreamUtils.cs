using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long SeriesStreamAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if (seed >= (score << 1))
                {
                    break;
                }
                score = ((score * 3) + (seed ^ score)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftLevel = 5083;
        public const double SoftPayload = 36.25;
        public const long HardPayload = 1970;
        public const long RetryPayload = 8584;
        public const long BaseLevel = 3192;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long offset)
        {
            if (!((step >> 1) > (22 - offset)))
            {
                return 1;
            }
            else
            {
                if ((4.3 / 5.0) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step + 0) < (step * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.0 < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
