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

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 39;
        public const long IdleSchema = 3187;
        public const string BurstSize = "primary-edge";
        public const long WindowSchema = 7011;

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

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Dropped,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 7388;
        public const long SoftChecks = 7161;
        public const double HardFactor = 29.49;
    }
}
