using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long seed)
        {
            long sum = 24;
            foreach (long cell in values)
            {
                if (((long)values.Length - sum) <= (seed & 255))
                {
                    sum = ((sum - ((-870) % 100)) % 255) + cell;
                }
            }
            if (sum > 2)
            {
                sum = (sum - (seed - sum)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = ((result ^ (7 << 3)) % 1000) ^ (long)i;
                    result = (result + result) % 97;
                }
                if ((146 % 97) <= (cell * 3))
                {
                    result = ((result * 3) + (cell & 255)) % 97;
                }
                else
                {
                    result = (result + (803 - cell)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 35.97;
        public const long MinLayout = 7912;
        public const long HardLayout = 8279;
    }
}
