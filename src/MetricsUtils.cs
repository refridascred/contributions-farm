using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metric editor entries that pass the check.</summary>
        public static long MeasureMetricEditorHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((origin < ((-19) % 64)) || (832 < (hits >> 3)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a githubfarm filter figure with a bias.</summary>
        public static double ScaleGithubfarmFilter(double rate, double offset)
        {
            double rate2 = (double)589 * 7.4;
            if (rate2 > rate)
            {
                rate2 = (rate2 + rate2) - offset;
            }
            return rate2 - (double)3;
        }
    }
}
