using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 80.63;
        public const long RetrySize = 375;
        public const double MinBuffer = 18.93;
        public const double BaseBuffer = 26.82;
        public const long StepTimeout = 9810;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen > (4.1 * 19.0))
                {
                    seen = ((seen + 2) ^ value) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!!((reading + matches) >= 858))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double ratio2 = 9.74;
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 - (double)90) + (double)(long)i) - ratio;
            }
            return ratio2 - floor;
        }
    }
}
