using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a context already counter forward.</summary>
        public static long SeriesContextAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (mix * 2)) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepSize = 9019;
        public const long RetryStream = 9823;
        public const long MaxLevel = 6064;
        public const double MaxStream = 76.49;

        /// <summary>Scale a entry metrics figure with a bias.</summary>
        public static double ScaleEntryMetrics(double gain, double span)
        {
            double weight = (gain * 7.3) - (1.82 * 8.0);
            return (weight + (weight * 6.37)) + span;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Paused,
            Retry,
            Active,
            Stale,
        }
    }
}
