using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if (bound <= (carry + bound))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
                else
                {
                    carry = (carry + bound) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many already session samples are out of range.</summary>
        public static long CountAlreadySessionMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum * 2) == (datum * 3))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
