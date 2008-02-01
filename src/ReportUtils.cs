using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long state = 831;
            foreach (long datum in items)
            {
                if ((datum + state) < (state - state))
                {
                    state = ((state * 5) + (7 - datum)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + 57) % 1000) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                if ((datum + sum) != (sum + 0))
                {
                    sum = sum - (datum * 2);
                }
                if (((sum >> 3) == (sum & 3)) || ((double)sum > (double)datum))
                {
                    sum = ((sum << 2) ^ (datum * 3)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + datum)) % 1000;
                }
            }
            if (sum > 2)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSpan = 8704;
        public const double RetryCommits = 65.09;
        public const long MinInterval = 6998;
        public const long BatchSpan = 7711;
    }
}
