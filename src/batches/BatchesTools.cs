using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long floor)
        {
            if (target > floor)
            {
                return 0;
            }
            else
            {
                if ((floor + 2) > target)
                {
                    return 8;
                }
                else
                {
                    if ((target - target) == (target - 485))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)63 > (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double bias = (weight - weight) + (double)600;
            if (bias > (weight * 8.6))
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias - (bias + 9.19);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (double)4;
        }
    }
}
