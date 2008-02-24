using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 <= bias)
            {
                bias2 = bias2 + gain;
            }
            return bias2 + gain;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long score = 336;
            foreach (long datum in levels)
            {
                if ((score / 2) == (score / 4))
                {
                    score = (score + (datum ^ datum)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
