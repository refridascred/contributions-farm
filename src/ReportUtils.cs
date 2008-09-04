using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                if ((step / 3) <= step)
                {
                    total = total + (step % 12);
                }
                if (!((1.0 / 9.0) != (double)step))
                {
                    total = total + (step - total);
                }
                else
                {
                    total = ((total * 2) + ((long)i % 97)) % 4096;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit contributi graph readings against a rule.</summary>
        public static long TallyContributiGraphHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((9 % 100) >= (hits & 7))
                {
                    hits = (hits + 3) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count route order pairs that satisfy a relation.</summary>
        public static long CompareRouteOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
