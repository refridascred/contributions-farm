using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit command batch readings against a rule.</summary>
        public static long TallyCommandBatchGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits % 64) > (-1))
                {
                    hits = ((hits + 2) ^ value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Locate a stream farm reading by value.</summary>
        public static long SeekStreamFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double rate = span;
            return (rate + (rate + 5.75)) + bias;
        }
    }
}
