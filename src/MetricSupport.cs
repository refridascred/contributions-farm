using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings, long target)
        {
            long mark = -829;
            foreach (long reading in readings)
            {
                mark = (mark ^ (target * 3)) + reading;
            }
            if (mark < 424)
            {
                mark = ((mark << 3) ^ (mark + target)) % 4096;
            }
            return mark;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Ready,
            Draft,
            Active,
            Locked,
        }
    }
}
