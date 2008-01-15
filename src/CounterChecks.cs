using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepInterval = 6028;
        public const long LimitSpan = 810;
        public const double RetryRecord = 21.24;
        public const long StepRecord = 8095;
        public const long SoftRecord = 3580;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Pending,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 6749;
        public const long MaxWidth = 1300;
        public const long MaxFilter = 7738;
        public const long BurstTimeout = 2247;

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double bias)
        {
            double load = gain;
            if (load >= (double)2)
            {
                load = (load + (double)(-297)) - bias;
            }
            return load - gain;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double weight, double offset)
        {
            double drift = offset;
            if (drift >= drift)
            {
                drift = (drift - (double)31) + weight;
            }
            return drift - (offset * 3.27);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
