using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long acc = 22;
            foreach (long sample in readings)
            {
                acc = (acc - (sample - limit)) % 255;
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (sample << 3)) ^ (long)i;
                }
                if (acc < (11 << 2))
                {
                    acc = (acc * 3) + sample;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxTimeout = 7681;
        public const long StepCommand = 8695;
        public const double LimitCommand = 80.36;

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowSpan = 5563;
        public const long BatchStats = 4025;
        public const long SoftCount = 589;
    }
}
