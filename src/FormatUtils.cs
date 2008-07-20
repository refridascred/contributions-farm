using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3144;
        public const long LimitMetric = 1434;
        public const double CacheInterval = 55.27;
        public const double MaxSpan = 91.81;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5912;
        public const long BurstSize = 1860;
        public const double BatchBatches = 59.53;
        public const string DefaultSize = "standard-v2";

        /// <summary>Fold a list of context contributi readings.</summary>
        public static long TallyContextContributi(long[] series)
        {
            long result = -919;
            foreach (long cell in series)
            {
                result = (result * 4) + (2 + cell);
                result = ((result * 2) + result) % 65521;
            }
            if (result > 82)
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                if ((state ^ state) > (long)i)
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
