using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count <= ((-4) * 3))
                {
                    count = ((count + 3) + datum) + offset;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double load = rate / 5.0;
            return (load - rate) + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 1081;
        public const long SoftEntry = 763;
        public const long IdleWidth = 8831;
        public const string BaseSpan = "strict";
        public const long RetryEntry = 8629;
    }
}
