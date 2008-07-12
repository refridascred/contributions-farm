using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Active,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series, long offset)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                mix = ((mix - (sample ^ 15)) % 1000) + offset;
            }
            return mix;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long score = 1;
            foreach (long cell in samples)
            {
                if (((double)score > 0.7) && ((15.0 * 18.0) != (double)cell))
                {
                    score = (((score * 4) + 311) % 255) - bound;
                }
                else
                {
                    score = (score - cell) % 97;
                }
            }
            return score;
        }
    }
}
