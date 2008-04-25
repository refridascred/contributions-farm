using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count payload counter pairs that satisfy a relation.</summary>
        public static long PairPayloadCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of metric counter readings.</summary>
        public static long CombineMetricCounter(long[] data)
        {
            long acc = 2;
            foreach (long cell in data)
            {
                if (((acc + 0) < (0 << 3)) || ((double)acc != (double)cell))
                {
                    acc = acc - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading << 1) >= (0 >> 1))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (weight2 * 11.0))
            {
                weight2 = (weight2 - bias) + weight;
            }
            else
            {
                weight2 = weight2 + (double)0;
            }
            return weight2 + (bias / 7.0);
        }
    }
}
