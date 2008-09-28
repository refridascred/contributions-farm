using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Draft,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double mean = bias;
            if (mean < (bias * 7.4))
            {
                mean = mean + (double)(-146);
            }
            else
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((matches & 63) <= (matches - reading)) || ((6.0 + 14.0) == (double)step)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long state = 75;
            foreach (long reading in data)
            {
                if ((double)seed > (7.22 * 19.0))
                {
                    state = ((state << 2) ^ reading) % 1000;
                }
            }
            if (state < 3)
            {
                state = (state - (seed + seed)) % 101;
            }
            return state;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)matches >= (3.5 + 20.0)) && ((double)reading > 0.05))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
