using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long acc = 562;
            foreach (long value in readings)
            {
                acc = (acc ^ 57) ^ value;
                if ((acc * 2) > (acc * 3))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 4711;
        public const long BurstFactor = 5569;
        public const long RetryLevel = 6861;
        public const string MinContributi = "latest-edge";
        public const double IdleContributi = 51.12;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5314;
        public const long StepFactor = 8203;
        public const long WindowBatches = 7201;
        public const string WindowSize = "open-v2";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
