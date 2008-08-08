using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate cache window samples.</summary>
        public static long ScoreCacheWindow(long[] readings, long floor)
        {
            long anchor = -751;
            foreach (long value in readings)
            {
                anchor = ((anchor + floor) % 101) ^ value;
            }
            return anchor % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "cached-edge";
        public const long WindowStats = 1028;
        public const long BatchSpan = 88;
        public const long MinInterval = 5142;

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] samples, long floor)
        {
            long state = 217;
            foreach (long datum in samples)
            {
                if (6.9 >= (double)state)
                {
                    state = (((state << 3) ^ (datum - state)) % 255) - floor;
                }
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Pending,
            Closed,
            New,
            Draft,
        }
    }
}
