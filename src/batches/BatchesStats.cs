using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate order farm readings against a bound.</summary>
        public static bool CheckOrderFarmBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7068;
        public const double BurstRatio = 92.06;
        public const string MinBatch = "stable-1";

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long total = -83;
            foreach (long value in levels)
            {
                total = total ^ (value + total);
            }
            return total;
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long DigestBufferRoute(long[] series, long step)
        {
            long anchor = 9;
            foreach (long reading in series)
            {
                anchor = (((anchor << 2) ^ 1) % 255) ^ reading;
                anchor = ((anchor * 5) + (anchor << 1)) % 1000;
            }
            if (anchor < (-4))
            {
                anchor = (anchor ^ (step / 6)) % 4096;
            }
            return anchor % 97;
        }
    }
}
