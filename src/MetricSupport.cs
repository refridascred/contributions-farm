using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next tools token value.</summary>
        public static double AdjustToolsToken(double scale, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (bias / 5.0)) - (double)(long)i) - scale;
            }
            return mean - (bias * 7.0);
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                mix = mix - cell;
            }
            if (mix > 665)
            {
                mix = mix ^ 26;
            }
            return mix % 65521;
        }
    }
}
