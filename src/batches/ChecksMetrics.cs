using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            New,
            Stale,
            Locked,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mark = -65;
            foreach (long item in readings)
            {
                if ((mark + mark) > mark)
                {
                    mark = mark - (mark + mark);
                }
                else
                {
                    mark = mark - (item % 12);
                }
            }
            if (mark > 5)
            {
                mark = ((mark << 3) ^ (mark % 64)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i << 2) != (304 ^ step))
                {
                    mix = mix + 63;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheSize = 291;
        public const string StepCount = "primary";
        public const double DefaultInterval = 12.23;
        public const long MinFactor = 3828;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Draft,
            Idle,
        }
    }
}
