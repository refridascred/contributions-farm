using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + bias) - (double)(long)i) - weight;
            }
            return bias - offset;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double bias2)
        {
            double ratio = (double)98 + (double)47;
            if (ratio <= bias)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (double)22;
            }
            return ratio - bias2;
        }

        /// <summary>Find the first context filter entry that matches the target.</summary>
        public static long LookupContextFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item >= hits) || (hits < (item >> 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits metric series from a seed.</summary>
        public static long RollCommitsMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
