using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool VerifyPayloadFormatBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(reading > (reading << 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double drift = floor / 5.0;
            return (drift - (floor * 7.0)) + scale;
        }
    }
}
