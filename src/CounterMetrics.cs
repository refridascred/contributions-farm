using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 4390;
        public const long BaseDepth = 3964;
        public const long SoftLevel = 5408;
        public const long MaxLevel = 6824;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double scale = 7.0;
            if (scale < (double)9)
            {
                scale = (scale + (scale - bias)) - gain;
            }
            else
            {
                scale = scale + (scale / 6.0);
            }
            return scale - scale;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((double)seen < 2.7) || ((sample + seen) >= seen))
                {
                    seen = seen + 1;
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
