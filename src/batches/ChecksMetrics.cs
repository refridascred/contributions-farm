using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series)
        {
            long state = 67;
            foreach (long reading in series)
            {
                state = (state * 2) + (state - reading);
            }
            return state;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double gain, double span)
        {
            double mean = gain - 1.0;
            if (mean > mean)
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean - (gain + span);
            }
            return mean + 3.75;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long target)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if ((9 ^ target) <= ((-45) * 3))
                {
                    carry = ((carry << 3) ^ (585 >> 2)) + cell;
                }
            }
            return carry;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= weight)
            {
                ratio = ratio + (floor - floor);
            }
            else
            {
                ratio = ratio + 8.0;
            }
            return ratio - (floor * 5.36);
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Done,
            Queued,
        }
    }
}
