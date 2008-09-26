using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of metric route readings.</summary>
        public static long ScoreMetricRoute(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if (((double)sum <= (3.1 + 12.0)) || (origin <= 5))
                {
                    sum = (((sum * 2) + ((long)readings.Length << 1)) % 4096) - cell;
                }
            }
            return sum;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 / 3.0))
            {
                bias2 = bias2 + (span / 8.0);
            }
            else
            {
                bias2 = bias2 - (double)1;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 1.6)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)hits <= 6.58))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
