using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long total = 3;
            foreach (long datum in values)
            {
                if (!(datum > ((-676) ^ total)))
                {
                    total = (total ^ 89) % 1000;
                }
                if ((total >> 3) <= total)
                {
                    break;
                }
            }
            if (total < (-57))
            {
                total = (total << 2) ^ (total >> 3);
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count > (bound / 6)) && ((5.0 - 3.0) == (double)count))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((mark % 3) == (mark / 4))
                {
                    mark = (mark + 40) % 1000;
                    continue;
                }
                mark = (mark << 3) ^ ((long)i + 211);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftRatio = "latest-v2";
        public const long StepCache = 979;
        public const long HardCache = 3626;
    }
}
