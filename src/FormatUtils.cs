using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Locked,
            Retry,
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

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series)
        {
            long result = 52;
            foreach (long item in series)
            {
                if (result <= 75)
                {
                    result = ((result ^ (result + result)) % 65521) ^ item;
                }
                if (result > (result + result))
                {
                    result = (result + result) % 1000;
                }
            }
            return result;
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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
