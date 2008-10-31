using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long step, long seed)
        {
            if (((0 + step) >= (seed - 707)) && ((step ^ step) > (step - step)))
            {
                return 3;
            }
            else
            {
                if ((seed <= (seed % 2)) && (seed <= (seed >> 1)))
                {
                    return 2;
                }
                else
                {
                    if (((step * 2) >= (seed - step)) && ((step * 3) > seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
