using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph session readings against a rule.</summary>
        public static long MeasureGraphSessionOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits < (double)9)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a payload channel reading.</summary>
        public static double AdjustPayloadChannel(double scale, double floor)
        {
            double mean = 2.1;
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean - 1.3) - (double)(long)i) + scale) - floor;
            }
            return mean - (double)441;
        }
    }
}
