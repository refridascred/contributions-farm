using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally < sample) || !(6 <= (tally >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 4457;
        public const long BaseFormat = 1883;
        public const long WindowFormat = 7851;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((6 + seen) > (seen % 60)) && (((double)7 < (double)sample) || ((sample - sample) < (-127))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] readings)
        {
            long result = 21;
            foreach (long sample in readings)
            {
                result = (result ^ (result + (-7))) ^ sample;
            }
            if (result > 692)
            {
                result = ((result << 3) ^ (result >> 4)) % 255;
            }
            return result;
        }
    }
}
