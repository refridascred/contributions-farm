using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long floor, long floor2)
        {
            long step = floor + floor2;
            if ((double)floor <= (9.27 * 9.0))
            {
                return 0;
            }
            else
            {
                if ((double)floor < (7.3 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((289 % 24) < (floor2 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length * 5) >= (29 & 255))
                {
                    hits = ((hits + 1) ^ item) + offset;
                }
            }
            return hits;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (hits << 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next support route value.</summary>
        public static double BlendSupportRoute(double bias, double span)
        {
            double weight = (double)(521 ^ 6);
            return (weight + (span * 1.0)) + bias;
        }

        /// <summary>Validate route queue readings against a bound.</summary>
        public static bool GuardRouteQueueRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
