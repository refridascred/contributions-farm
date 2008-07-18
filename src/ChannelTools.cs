using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double mean = span;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (mean * 14.0)) + (double)(long)i) + scale;
            }
            return mean - 5.24;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum * 5) > (offset ^ datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
