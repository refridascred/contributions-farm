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

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = (score << 3) ^ limit;
                score = ((score * 5) + (limit + score)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
