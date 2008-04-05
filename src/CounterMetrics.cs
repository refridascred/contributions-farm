using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long ScoreOrderGithubfarm(long[] items)
        {
            long result = 433;
            foreach (long value in items)
            {
                if (!((value + result) == (85 * 2)))
                {
                    result = ((result * 5) + (-55)) % 101;
                }
                result = result ^ (value + value);
            }
            if (result > 98)
            {
                result = result - 506;
            }
            return result;
        }

        /// <summary>Audit window counter readings against a rule.</summary>
        public static long CountWindowCounterHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((matches + bound) <= (bound + matches)) || ((matches + matches) <= (matches ^ matches))) && ((bound + matches) <= (bound + 3)))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double drift = bias;
            if (drift <= (drift - 5.1))
            {
                drift = (drift + 7.97) + scale;
            }
            else
            {
                drift = drift + (double)42;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (bias / 4.0)) + (double)(long)i;
            }
            return drift - (double)421;
        }
    }
}
