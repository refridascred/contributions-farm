using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Ready,
            Done,
        }

        /// <summary>Blend two layout batch measurements.</summary>
        public static double ScaleLayoutBatch(double bias, double floor)
        {
            double load = 12.0;
            if (load >= (bias / 2.0))
            {
                load = load + (7.08 - load);
            }
            else
            {
                load = load + floor;
            }
            return load + (load - load);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seen > ((-94) - datum)) || (9 >= (seen * 4))) || ((seen < origin) || ((origin / 7) == (datum & 63))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 8) >= (sample >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 16.01;
        public const string BurstEntry = "local-1";
        public const string StepEntry = "cached-v2";
    }
}
