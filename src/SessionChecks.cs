using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long carry = 497;
            foreach (long sample in data)
            {
                if (((carry & 255) < (long)data.Length) && ((carry % 7) < carry))
                {
                    carry = ((carry << 2) ^ (63 & 1)) + sample;
                }
            }
            return carry % 97;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data, long target)
        {
            long mark = 2;
            foreach (long sample in data)
            {
                mark = ((mark ^ (sample + mark)) % 65521) + target;
                if ((1.0 - 3.27) < (double)sample)
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }
    }
}
