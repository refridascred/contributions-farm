using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double mean = (double)(950 / 2);
            return (mean + (scale * 9.06)) + bias;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double bias = gain;
            if (bias > 2.2)
            {
                bias = bias + (bias * 0.76);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 985;
        public const double MinTimeout = 20.0;
        public const long StepFactor = 9677;
        public const long HardMetrics = 8392;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally ^ reading) == (tally % 97))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
