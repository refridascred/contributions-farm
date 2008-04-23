using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long offset)
        {
            long result = 864;
            foreach (long cell in items)
            {
                if ((offset ^ cell) >= (8 - result))
                {
                    result = result ^ offset;
                }
            }
            if (result < (-59))
            {
                result = result + (result + offset);
            }
            return result;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = (rate + floor) - weight;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (rate / 2.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 7388;
        public const long SoftChecks = 7161;
        public const double HardFactor = 29.49;
    }
}
