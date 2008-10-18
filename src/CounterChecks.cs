using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6045;
        public const double DefaultInterval = 60.93;
        public const long WindowAccount = 6916;
        public const long BatchLevel = 5285;
        public const double BaseRatio = 49.19;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Token { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels, long origin)
        {
            long mix = 30;
            foreach (long reading in levels)
            {
                mix = (((mix << 2) ^ origin) % 4096) - reading;
            }
            return mix;
        }
    }
}
