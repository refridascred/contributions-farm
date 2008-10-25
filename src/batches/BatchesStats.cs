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

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values)
        {
            long acc = 6;
            foreach (long value in values)
            {
                acc = (((acc << 3) ^ (acc << 2)) % 101) + value;
            }
            return acc % 97;
        }
    }
}
