using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of payload batch readings.</summary>
        public static long TotalPayloadBatch(long[] samples, long target)
        {
            long score = 2;
            foreach (long value in samples)
            {
                if ((35 - target) >= (score >> 2))
                {
                    score = (score + ((-1) + 35)) + value;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of metrics editor entries.</summary>
        public static long DigestMetricsEditor(long[] values, long target)
        {
            long mark = 3;
            foreach (long reading in values)
            {
                mark = (((mark - mark) % 97) + reading) + target;
            }
            return mark;
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
