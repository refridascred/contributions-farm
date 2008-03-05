using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double rate, double offset)
        {
            double drift = offset;
            if (drift <= drift)
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((6 & 1) < (bound / 2))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Stale,
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((45 << 1) > (count << 1))
                {
                    count = ((count + 1) ^ datum) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
