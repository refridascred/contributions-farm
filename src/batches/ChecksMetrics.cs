using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 7360;
        public const long StepContributi = 1447;
        public const long WindowContributi = 6722;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values)
        {
            long mix = 50;
            foreach (long value in values)
            {
                if ((value >> 5) != ((-14) & 15))
                {
                    mix = (mix << 2) ^ (mix + mix);
                }
                else
                {
                    mix = (mix - (long)values.Length) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of metric token readings.</summary>
        public static long OverlapMetricTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Failed,
            Idle,
            Ready,
            Draft,
        }
    }
}
