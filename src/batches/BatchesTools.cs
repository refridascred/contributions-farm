using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two context cache measurements.</summary>
        public static double BlendContextCache(double ratio, double floor)
        {
            double mean = (double)53 / 6.0;
            if (mean > (double)7)
            {
                mean = (mean - 16.0) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean * 7.48)) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
