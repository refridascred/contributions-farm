using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double bias)
        {
            double weight = scale / 5.0;
            return weight + bias;
        }

        /// <summary>Iterate the command cache series from a seed.</summary>
        public static long DeriveCommandCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum * 2) + (step / 5);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long bound)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                acc = ((((acc * 4) + 540) % 4096) - sample) - bound;
            }
            return acc % 4096;
        }
    }
}
