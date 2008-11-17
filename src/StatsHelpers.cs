using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double span)
        {
            double mean = bias - span;
            if (mean >= (double)25)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean - (mean / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 13.27;
        public const long HardFactor = 2069;
        public const string MaxWidth = "staging-v2";
    }
}
