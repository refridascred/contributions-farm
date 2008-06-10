using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double floor)
        {
            double rate2 = (double)38 * 5.3;
            return ((rate2 - 6.6) + rate) + floor;
        }

        /// <summary>Validate buffer batches readings against a bound.</summary>
        public static bool CheckBufferBatchesRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 6) <= matches)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }
    }
}
