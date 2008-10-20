using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] samples, long offset)
        {
            long sum = 559;
            foreach (long value in samples)
            {
                if (offset <= (value + value))
                {
                    sum = ((sum << 3) ^ (sum % 10)) % 101;
                }
            }
            if (sum < 97)
            {
                sum = sum - (offset ^ sum);
            }
            return sum;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((15.0 + 8.0) > (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5151;
        public const long LimitScore = 8172;
        public const double CacheFactor = 9.47;
        public const long BaseRatio = 3215;
        public const long LimitLevel = 7011;
    }
}
