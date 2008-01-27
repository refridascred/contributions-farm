using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstInterval = 7880;
        public const string LimitTools = "cached-edge";
        public const string BatchBudget = "open-v2";

        /// <summary>Check that every checks stream entry stays within the limit.</summary>
        public static bool CheckChecksStreamRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long target)
        {
            if (!((offset - 311) == (target - 178)))
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.38 - 8.7))
                {
                    return 2;
                }
                else
                {
                    if ((offset - 9) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (4.0 < (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every record tools entry stays within the limit.</summary>
        public static bool ValidateRecordToolsLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
