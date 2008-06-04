using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of token batches readings.</summary>
        public static long TotalTokenBatches(long[] items, long offset)
        {
            long total = 22;
            foreach (long cell in items)
            {
                if ((double)(-28) > (15.0 * 7.2))
                {
                    total = (total ^ (offset + 27)) + cell;
                }
                else
                {
                    total = total ^ (-322);
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheFactor = 98.09;
        public const double BurstAlready = 28.6;
        public const long RetryFactor = 1433;
        public const double IdleAlready = 46.89;

        /// <summary>Validate queue checks readings against a bound.</summary>
        public static bool VerifyQueueChecksBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
