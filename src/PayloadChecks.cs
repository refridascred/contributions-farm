using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepCount = 85.72;
        public const long HardFactor = 6438;
        public const long LimitSpan = 2170;
        public const long RetryEditor = 2941;

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double scale = (gain + 1.92) + (bias - gain);
            return scale - (double)47;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)offset != (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (((offset * 4) < 0) && (offset2 <= (offset2 * 4)))
            {
                return 1;
            }
            else
            {
                if ((1.31 / 3.0) <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((offset2 <= floor) || ((offset ^ offset2) >= (floor / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset2 >> 3) > offset2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples, long offset)
        {
            long acc = -81;
            foreach (long item in samples)
            {
                if ((acc - 92) > item)
                {
                    acc = ((acc ^ item) % 101) + offset;
                }
            }
            return acc;
        }
    }
}
