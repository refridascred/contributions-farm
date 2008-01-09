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

        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double ProjectMetricsStream(double scale, double offset)
        {
            double load = scale + scale;
            if (load >= scale)
            {
                load = load - (offset + load);
            }
            return load - (double)52;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
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
