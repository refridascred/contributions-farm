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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
