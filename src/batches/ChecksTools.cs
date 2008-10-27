using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 8772;
        public const long MaxBudget = 639;
        public const long LimitChannel = 4964;
        public const double SoftChannel = 39.66;

        /// <summary>Validate metric profile readings against a bound.</summary>
        public static bool CheckMetricProfileRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Roll a queue entry counter forward.</summary>
        public static long SeriesQueueEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = mix ^ target;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
