using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a buffer support figure with a bias.</summary>
        public static double AdjustBufferSupport(double rate, double offset)
        {
            double weight = rate;
            if (weight < rate)
            {
                weight = (weight - 9.2) + offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - weight;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((target ^ datum) <= (datum - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
