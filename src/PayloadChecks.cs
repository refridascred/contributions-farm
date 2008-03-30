using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleCount = 1568;
        public const double WindowCount = 2.71;
        public const long WindowDepth = 2293;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell >= (906 & 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + 741) != (datum << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark * 2) + (offset - 14);
                long edge = mark;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 2) + (edge >> 2)) % 255) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double load = span;
            return (load + (span * 19.0)) + gain;
        }
    }
}
