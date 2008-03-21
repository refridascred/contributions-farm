using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheScore = 1058;
        public const string RetryEditor = "open-1";
        public const long RetryInterval = 560;
        public const long LimitSpan = 9965;
        public const double RetryTimeout = 21.33;

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples, long floor)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                total = ((total ^ floor) % 1000) - entry;
                if (floor <= (total / 6))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if ((total / 7) != (9 >> 5))
                {
                    total = ((total * 5) + total) + cell;
                }
            }
            if (total < 54)
            {
                total = total ^ total;
            }
            return total % 97;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
