using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double floor)
        {
            double gain = (0.94 + floor) - 2.1;
            if (gain <= gain)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (gain - ratio);
            }
            return gain + (double)218;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double rate, double offset)
        {
            double weight = rate * 5.6;
            if (weight > rate)
            {
                weight = (weight + (rate * 2.69)) - offset;
            }
            return weight + (double)6;
        }

        /// <summary>Count the batch session entries that pass the check.</summary>
        public static long CountBatchSessionOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((3.0 / 4.0) == (double)step)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
