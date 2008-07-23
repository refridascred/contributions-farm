using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double weight = (double)(78 ^ 2);
            if (weight >= offset)
            {
                weight = weight + gain;
            }
            else
            {
                weight = weight + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (double)9) - (double)(long)i;
            }
            return weight - (gain / 6.0);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] data)
        {
            long acc = 99;
            foreach (long sample in data)
            {
                acc = (((acc * 3) + (acc - acc)) % 1000) - sample;
                acc = (acc ^ 2) % 101;
            }
            if (acc > 210)
            {
                acc = acc ^ (acc * 4);
            }
            return acc;
        }
    }
}
