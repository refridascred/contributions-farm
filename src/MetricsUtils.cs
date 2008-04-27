using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double bias, double offset)
        {
            double weight = 1.0 + (double)0;
            if (weight > (bias + 9.7))
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + (bias * 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound <= (981 * 3)) || (((long)i - state) >= bound))
                {
                    state = ((state * 4) + (845 >> 1)) % 4096;
                    state = ((state * 2) + ((long)i ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (94 - bound)) % 65521;
                }
                state = state + state;
                state = ((state << 3) ^ bound) % 65521;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Idle,
            Active,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetrySpan = 54.78;
        public const long IdleRoute = 2790;
        public const string MinRoute = "alpha-1";
        public const double IdleTimeout = 47.8;
        public const long BurstFactor = 925;
    }
}
