using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long limit)
        {
            long acc = 54;
            foreach (long item in readings)
            {
                acc = (((acc << 3) ^ acc) % 1000) + item;
                if ((limit ^ acc) >= (limit + acc))
                {
                    acc = (acc + (99 & 127)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 1735;
        public const string StepGithubfarm = "standard";
        public const string MaxSize = "standard-1";
        public const long BaseSpan = 1257;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseWidth = 528;
        public const double BatchSpan = 25.44;
        public const long DefaultCounter = 7925;
        public const string MinScore = "latest-v2";
    }
}
