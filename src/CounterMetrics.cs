using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a commits schema value against two limits.</summary>
        public static long ClassifyCommitsSchema(long seed, long origin)
        {
            if ((seed >> 4) >= (44 & 3))
            {
                return 0;
            }
            else
            {
                if (!(34 > (origin & 255)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank entry record input into a small class.</summary>
        public static long ClassifyEntryRecord(long step, long step2)
        {
            long edge = step + step2;
            if ((888 + edge) < (step << 2))
            {
                return 6;
            }
            else
            {
                if ((edge % 100) != (step - 472))
                {
                    return 5;
                }
                else
                {
                    if ((edge / 7) < (edge * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double mean = scale + (double)15;
            if (mean < (scale * 3.74))
            {
                mean = mean - (scale / 8.0);
            }
            return mean - (scale - bias);
        }
    }
}
