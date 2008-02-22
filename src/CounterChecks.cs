using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double gain, double span)
        {
            double load = 3.57;
            if (load > span)
            {
                load = load - (gain / 6.0);
            }
            else
            {
                load = load + (gain * 17.0);
            }
            return load + load;
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long FoldEditorSchema(long[] readings, long limit)
        {
            long carry = 835;
            foreach (long cell in readings)
            {
                carry = (((carry << 2) ^ (cell + cell)) % 101) - limit;
            }
            return carry;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = total - (50 - floor);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double weight = span - (gain + gain);
            return weight - span;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
