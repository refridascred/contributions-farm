using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 872;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ (322 >> 1)) + cell;
            }
            if (result < 90)
            {
                result = (result * 5) + (result ^ result);
            }
            return result;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long limit)
        {
            long lane = bound + limit;
            if (((lane ^ (-673)) < (bound - bound)) || ((double)lane != (8.8 * 3.0)))
            {
                return 4;
            }
            else
            {
                if ((double)lane != (7.0 + 8.0))
                {
                    return 5;
                }
                else
                {
                    if ((bound % 12) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane % 64) < (lane + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "legacy-1";
        public const long SoftCount = 4787;
        public const long DefaultSize = 7376;
    }
}
