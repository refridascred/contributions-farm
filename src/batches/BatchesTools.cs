using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items)
        {
            long mix = 3;
            foreach (long value in items)
            {
                if ((84 >> 5) < value)
                {
                    mix = (mix ^ (mix << 2)) % 255;
                }
            }
            if (mix < (-212))
            {
                mix = (mix + mix) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length == (6.6 * 3.17))
                {
                    hits = ((hits + 2) + reading) + offset;
                }
            }
            return hits;
        }
    }
}
