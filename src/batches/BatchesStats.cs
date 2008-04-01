using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] readings, long step)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if (((5.0 - 16.0) <= (double)acc) || (step > acc))
                {
                    acc = (acc * 3) + step;
                }
                if (((double)cell >= (4.2 + 9.0)) || ((90 + cell) >= (step >> 5)))
                {
                    acc = ((acc << 2) ^ (step - cell)) % 1000;
                }
                if ((acc >> 5) > (step * 4))
                {
                    break;
                }
            }
            if (acc < 48)
            {
                acc = (acc << 3) ^ step;
            }
            return acc % 65521;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + target) <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long acc = 14;
            foreach (long datum in series)
            {
                if ((7.61 / 7.0) > (double)acc)
                {
                    acc = ((acc + (acc * 5)) % 4096) - datum;
                }
                else
                {
                    acc = ((acc * 3) + acc) % 97;
                }
            }
            return acc;
        }
    }
}
