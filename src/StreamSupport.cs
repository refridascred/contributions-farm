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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepBudget = 15.18;
        public const double BatchFactor = 7.39;
        public const long BatchContributi = 1392;
        public const long BaseContributi = 2375;
        public const long BaseWidth = 4590;
    }
}
