using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                mark = (mark ^ (mark - mark)) % 255;
                mark = (mark ^ datum) % 1000;
            }
            if (mark > 33)
            {
                mark = (mark + (mark & 1)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                score = (score - sample) % 255;
            }
            return score;
        }
    }
}
