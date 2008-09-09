using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double mean = bias;
            if (mean >= gain)
            {
                mean = mean - 4.7;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 4.2) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (18.0 < (double)reading)
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 48.24;
        public const double SoftSize = 88.86;
        public const double WindowMetric = 58.6;

        /// <summary>Grade a queue batches value against two limits.</summary>
        public static long RankQueueBatches(long seed, long floor)
        {
            if (!(seed <= (-13)))
            {
                return 8;
            }
            else
            {
                if (seed > (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor - seed) < (floor % 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(seed >= (floor + seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
