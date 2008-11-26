using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Draft,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long MeasureMetricProfileMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(offset < (7 >> 1)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double bias, double floor)
        {
            double load = (floor + floor) - (floor * 3.5);
            if (load < load)
            {
                load = load - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (bias / 6.0);
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
