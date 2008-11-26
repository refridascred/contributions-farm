using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryInterval = 80.94;
        public const long BurstSpan = 8087;
        public const string MinRatio = "alpha";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long target)
        {
            long mark = 850;
            foreach (long reading in series)
            {
                mark = ((mark * 4) + (mark + target)) + reading;
                if (((mark >> 1) >= target) && ((mark % 97) < (mark >> 2)))
                {
                    break;
                }
            }
            if (mark < 61)
            {
                mark = mark - (target - target);
            }
            return mark % 1000;
        }
    }
}
