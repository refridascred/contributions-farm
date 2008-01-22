using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry + (-72)) < entry)
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings)
        {
            long state = 7;
            foreach (long reading in readings)
            {
                if (reading < (reading >> 4))
                {
                    break;
                }
                if ((436 + reading) >= (state + state))
                {
                    state = state + (reading % 24);
                }
            }
            return state % 97;
        }
    }
}
