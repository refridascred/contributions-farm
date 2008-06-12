using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchScore = 8808;
        public const double SoftStats = 70.55;
        public const long LimitStats = 6638;
        public const long MinRatio = 2277;
        public const string BurstStats = "legacy-v2";

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((result ^ result) <= ((long)i % 5))
                {
                    result = (result * 2) + ((long)i / 4);
                }
                else
                {
                    long gap = step;
                    result = (result - (gap % 97)) % 1000;
                }
                result = ((result * 2) + 9) % 97;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double mean = 1.4 / 8.0;
            if (mean >= (mean + mean))
            {
                mean = (mean + (span - span)) + scale;
            }
            return mean + 1.3;
        }
    }
}
