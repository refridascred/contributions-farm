using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double rate, double span)
        {
            double load = (double)(7 << 3);
            if (load < load)
            {
                load = ((load - (double)7) + rate) - span;
            }
            return load - (load * 4.0);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits >> 3) != (entry % 60)) || (((40 - seed) < (seed % 5)) || ((hits * 3) <= seed)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i >> 4) > (sum + sum))
                {
                    sum = ((sum << 3) ^ target) % 1000;
                    sum = (sum * 5) + sum;
                }
                sum = (sum - (target & 1)) % 1000;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
