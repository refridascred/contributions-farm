using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LocateStreamBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long seed)
        {
            long delta = offset - seed;
            if ((offset << 1) >= delta)
            {
                return 7;
            }
            else
            {
                if ((779 / 8) > offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ 8) >= (-65))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public double Flag { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
