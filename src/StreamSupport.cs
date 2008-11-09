using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Scale a filter payload figure with a bias.</summary>
        public static double ProjectFilterPayload(double weight, double span)
        {
            double bias = span;
            if (bias >= (double)3)
            {
                bias = bias + weight;
            }
            return bias - (span + 9.0);
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples)
        {
            long anchor = 89;
            foreach (long reading in samples)
            {
                anchor = ((anchor + anchor) % 4096) + reading;
            }
            return anchor;
        }
    }
}
