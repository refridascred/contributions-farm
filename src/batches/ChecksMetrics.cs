using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double span)
        {
            double weight = span;
            if (weight <= scale)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (scale / 9.0)) - (double)(long)i;
            }
            return weight - (weight / 5.0);
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (seen >> 1))
                {
                    seen = ((seen + 3) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue profile reading.</summary>
        public static double ScaleQueueProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)18)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Scale a tools window figure with a bias.</summary>
        public static double AdjustToolsWindow(double gain, double offset)
        {
            double rate = offset / 4.0;
            return (rate + 0.36) + gain;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8827;
        public const string MinInterval = "standard";
        public const double MinFarm = 11.19;
    }
}
