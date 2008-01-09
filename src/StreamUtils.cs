using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long result = 971;
            foreach (long item in levels)
            {
                if (!((result + result) >= (result >> 3)))
                {
                    result = ((result << 3) ^ (result ^ item)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 39.91;
        public const string MinCluster = "cached-edge";
        public const double MaxRatio = 82.42;

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] items, long offset)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if (!(sum >= item))
                {
                    sum = (sum ^ (offset + sum)) % 4096;
                }
            }
            if (sum < 120)
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (9 < seen)
                {
                    seen = ((seen + 3) - value) - seed;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
