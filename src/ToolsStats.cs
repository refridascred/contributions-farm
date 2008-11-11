using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 4142;
        public const double MaxFactor = 84.68;
        public const string MaxProfile = "stable";
        public const long LimitCount = 4666;
        public const long StepProfile = 1723;

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long floor)
        {
            long mark = 93;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = ((mark - 82) % 255) + (long)i;
                }
                if ((double)cell == (double)75)
                {
                    mark = (mark * 4) + (floor - floor);
                }
            }
            return mark % 1000;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double span)
        {
            double drift = bias * 9.4;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)(long)i) - span;
            }
            return drift + (double)25;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long TallyStreamOrderMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(reading > (bound % 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) == (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
