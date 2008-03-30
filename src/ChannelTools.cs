using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Done,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double load = bias;
            if (load < (8.4 + 3.65))
            {
                load = (load - (double)498) - bias2;
            }
            return load + (double)(-565);
        }
    }
}
