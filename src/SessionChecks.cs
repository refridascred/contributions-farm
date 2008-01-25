using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double span)
        {
            double bias = (span + span) / 3.0;
            return (bias - (span / 2.0)) + scale;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
