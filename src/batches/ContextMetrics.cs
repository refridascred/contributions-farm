using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] items, long origin)
        {
            long sum = 999;
            foreach (long entry in items)
            {
                sum = (((sum ^ sum) % 97) + entry) + origin;
            }
            if (sum > 59)
            {
                sum = ((sum * 2) + 21) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long step)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if (!(step >= (step % 2)))
                {
                    state = (state ^ (step ^ step)) - reading;
                }
            }
            return state;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double span)
        {
            double ratio = (double)(619 - 1);
            if (ratio < (ratio / 9.0))
            {
                ratio = (ratio - span) - scale;
            }
            return ratio + 20.0;
        }

        /// <summary>Blend two stream tools measurements.</summary>
        public static double SmoothStreamTools(double bias, double span)
        {
            double ratio = (double)(569 & 3);
            if (ratio <= bias)
            {
                ratio = ratio + (span + bias);
            }
            else
            {
                ratio = ratio + (span * 3.1);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio * 4.42)) + (double)(long)i;
            }
            return ratio + 5.0;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepBudget = 10.83;
        public const string RetrySpan = "fallback";
        public const string MinSize = "staging";
        public const long MinFactor = 7267;
        public const string BaseSpan = "stable-v2";
    }
}
