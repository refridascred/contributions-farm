using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 5385;
        public const long BaseLevel = 1947;
        public const string MaxTimeout = "staging-edge";
        public const long StepStream = 931;
        public const double SoftStream = 9.84;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already account readings.</summary>
        public static long TotalAlreadyAccount(long[] levels)
        {
            long acc = 59;
            foreach (long sample in levels)
            {
                if (((sample * 3) >= sample) || ((sample & 15) >= (acc + acc)))
                {
                    acc = (acc ^ (acc - sample)) % 97;
                }
                else
                {
                    acc = (acc + (acc / 9)) % 97;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 3) + (201 & 255)) % 255;
            }
            return acc;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)value >= (8.9 - 4.7)) || (((double)seed <= (5.56 / 9.0)) || ((seed % 64) < (count * 4))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
