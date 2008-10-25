using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 9578;
        public const double RetryScore = 51.23;
        public const double MinWindow = 29.09;
        public const double BatchCount = 68.93;

        /// <summary>Accumulate queue layout samples.</summary>
        public static long TallyQueueLayout(long[] readings)
        {
            long mix = 301;
            foreach (long sample in readings)
            {
                if ((sample ^ 7) == (mix - sample))
                {
                    mix = mix - (mix * 4);
                }
                else
                {
                    mix = mix ^ ((long)readings.Length * 5);
                }
                if (((sample + sample) > mix) || (mix >= sample))
                {
                    mix = (mix << 3) ^ sample;
                }
            }
            if (mix < 59)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultScore = 8078;
        public const long SoftLevel = 4006;
        public const long CacheInterval = 4737;

        /// <summary>Combine githubfarm channel values into a single score.</summary>
        public static long CombineGithubfarmChannel(long[] items)
        {
            long state = 57;
            foreach (long datum in items)
            {
                if (datum < state)
                {
                    state = (state * 5) + state;
                }
                else
                {
                    state = ((state << 2) ^ (25 & 31)) % 4096;
                }
            }
            return state % 65521;
        }
    }
}
