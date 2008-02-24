using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((target ^ target) <= (entry - 22))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if (step >= (anchor >> 4))
                {
                    anchor = anchor + step;
                }
                anchor = anchor - (6 + 155);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double ratio = span;
            if (ratio <= bias)
            {
                ratio = ratio - (double)1;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - ratio;
        }
    }
}
