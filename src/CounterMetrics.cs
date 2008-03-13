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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry ^ matches) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
