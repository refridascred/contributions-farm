using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batch record pair into a bucket.</summary>
        public static long BucketBatchRecord(long floor, long step)
        {
            if ((floor + floor) <= 118)
            {
                return 4;
            }
            else
            {
                if ((floor + 71) <= (step & 127))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < 11.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double mean = (4.0 + scale) + (19.0 + span);
            if (mean <= (span / 9.0))
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean + (span * 2.5);
            }
            return mean + span;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
