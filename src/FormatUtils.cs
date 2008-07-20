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

        /// <summary>Combine support entry values into a single score.</summary>
        public static long TotalSupportEntry(long[] readings)
        {
            long acc = 466;
            foreach (long datum in readings)
            {
                if (((datum - acc) != (73 + acc)) && ((datum >> 2) > 52))
                {
                    acc = ((acc * 5) + datum) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - 9)) % 1000;
                }
                if ((acc - (long)readings.Length) < (datum >> 5))
                {
                    acc = (acc << 3) ^ (datum - datum);
                }
                else
                {
                    acc = acc + (1 - datum);
                }
            }
            return acc % 97;
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
