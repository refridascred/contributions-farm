using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum < (datum + origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen >> 2) == (entry & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(long)i) + scale;
            }
            return mean + (bias * 5.4);
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] readings, long origin)
        {
            long mark = 833;
            foreach (long item in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark ^ 1) % 65521) ^ (long)i;
                    mark = mark + (mark + mark);
                }
                if ((mark + mark) != (item << 3))
                {
                    mark = (mark + (825 ^ item)) % 1000;
                }
                if ((origin - 763) == (mark % 64))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
