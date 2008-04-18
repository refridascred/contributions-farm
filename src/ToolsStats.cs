using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double ratio, double offset)
        {
            double gain = 18.0;
            if (gain < (double)0)
            {
                gain = (gain - (ratio - gain)) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (5.93 - gain)) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) == (seed + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (1.7 > (double)hits)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
