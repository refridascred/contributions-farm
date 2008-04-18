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

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Idle,
            Stale,
            Ready,
            Done,
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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry << 2) ^ floor) % 1000;
                carry = (carry + ((long)i + carry)) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
