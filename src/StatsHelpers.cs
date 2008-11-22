using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double load = rate + (span - rate);
            if (load <= 1.2)
            {
                load = load - (double)(-9);
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + 8.0;
        }

        /// <summary>Digest a series of stats report entries.</summary>
        public static long DigestStatsReport(long[] samples)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if ((acc <= (sample * 2)) && ((acc + sample) > (488 & 255)))
                {
                    acc = ((acc << 2) ^ (sample ^ acc)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((297 >> 5) != (seen << 1))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long CountStreamChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((hits - hits) > hits) && (((cell + 5) > (long)series.Length) && ((cell >> 1) <= (cell ^ cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
