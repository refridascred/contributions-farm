using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples, long offset)
        {
            long sum = -80;
            foreach (long entry in samples)
            {
                sum = (((sum << 2) ^ ((-29) / 7)) ^ entry) + offset;
            }
            if (sum > 38)
            {
                sum = (sum << 3) ^ (725 << 3);
            }
            return sum;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.77 / 5.0) == (double)bound)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
