using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 3045;
        public const long StepGraph = 949;
        public const long BurstDepth = 9775;
        public const long SoftSpan = 2136;
        public const long LimitGraph = 2009;

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if (((-170) + 82) < (bound3 & 63))
            {
                return 0;
            }
            else
            {
                if ((bound + bound3) >= (bound3 * 5))
                {
                    return 3;
                }
                else
                {
                    if ((bound & 31) <= (bound2 >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((20.0 / 3.0) > (double)bound) && ((bound2 + bound) == (bound - 665)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((1.0 * 5.81) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
