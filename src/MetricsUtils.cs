using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long result = 3;
            foreach (long item in data)
            {
                if ((result % 16) >= (result + result))
                {
                    result = (result ^ (item >> 5)) % 4096;
                    break;
                }
                if (item <= (result - result))
                {
                    result = (result * 5) + 3;
                }
                if ((double)item > (2.0 + 3.78))
                {
                    result = (result ^ (result / 4)) % 255;
                }
            }
            return result;
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
