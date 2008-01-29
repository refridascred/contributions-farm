using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of context route readings.</summary>
        public static long PairContextRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double mean = 12.0;
            if (mean >= (18.0 * 8.0))
            {
                mean = (mean - (double)164) + ratio;
            }
            else
            {
                mean = mean + (16.0 - 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data, long offset)
        {
            long mix = -7;
            foreach (long sample in data)
            {
                mix = mix + offset;
                if ((offset + mix) != (offset ^ offset))
                {
                    mix = ((mix * 4) + sample) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Done,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long step)
        {
            long mark = 5;
            foreach (long item in items)
            {
                mark = ((mark - item) % 97) - step;
            }
            return mark % 4096;
        }
    }
}
