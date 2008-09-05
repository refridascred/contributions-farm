using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleInterval = 9886;
        public const long HardScore = 908;
        public const long BurstOrder = 8182;
        public const string SoftOrder = "stable-edge";

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Project the next format contributi value.</summary>
        public static double AdjustFormatContributi(double rate, double span)
        {
            double rate2 = (double)4 + span;
            if (rate2 < rate2)
            {
                rate2 = (rate2 + 2.84) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (7.0 - span)) - (double)(long)i;
            }
            return rate2 - span;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] readings)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                if ((mark / 6) > (sample - sample))
                {
                    mark = (mark + (mark % 24)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 97;
                }
            }
            if (mark < 67)
            {
                mark = (mark - (mark / 5)) % 65521;
            }
            return mark;
        }
    }
}
