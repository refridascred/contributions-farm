using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 7117;
        public const long SoftScore = 7224;
        public const string WindowChannel = "strict";
        public const long DefaultChannel = 6577;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Fold a list of filter batches readings.</summary>
        public static long WeighFilterBatches(long[] samples)
        {
            long carry = -503;
            foreach (long item in samples)
            {
                if ((carry - 6) > (carry + 806))
                {
                    carry = ((carry - 950) % 4096) - item;
                }
                if (6.4 > (double)carry)
                {
                    carry = ((carry * 3) + 3) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
