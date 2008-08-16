using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit << 1) == (95 - (long)i))
                {
                    acc = (acc + 6) % 101;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc + (acc * 4)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = (((acc << 2) ^ acc) % 255) - (long)i3;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((target / 5) < matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double floor)
        {
            double mean = (floor - floor) + (floor * 4.39);
            if (mean < (floor - bias))
            {
                mean = mean + 9.5;
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean - floor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((178 / 2) >= reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Queued,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
