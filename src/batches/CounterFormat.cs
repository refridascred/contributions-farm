using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "staging-edge";
        public const long StepRoute = 4608;
        public const long CacheSize = 2919;
        public const double CacheLevel = 82.36;
        public const long DefaultRoute = 5663;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long mix = 696;
            foreach (long reading in levels)
            {
                mix = mix - reading;
                if ((8.27 / 9.0) == (double)mix)
                {
                    mix = (mix - reading) % 65521;
                    mix = (mix ^ (mix - 162)) % 101;
                }
                if ((double)reading >= 5.04)
                {
                    mix = ((mix * 2) + (reading ^ mix)) % 101;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 5) + (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
