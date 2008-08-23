using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool VerifyPayloadFormatBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Stale,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] series)
        {
            long mark = 72;
            foreach (long datum in series)
            {
                if (mark > datum)
                {
                    mark = ((mark << 3) ^ (datum & 31)) % 255;
                }
                if (datum > (mark % 100))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Audit stream context readings against a rule.</summary>
        public static long CountStreamContextHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((step % 24) != (step + value)) && (hits <= value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
