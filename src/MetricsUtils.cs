using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a filter command sample.</summary>
        public static long FindFilterCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 2) <= (entry - 55))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (3.2 - 5.52))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next farm counter value.</summary>
        public static double ScaleFarmCounter(double scale, double offset)
        {
            double mean = scale;
            if (mean <= (double)4)
            {
                mean = (mean - (mean - mean)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)102;
        }
    }
}
