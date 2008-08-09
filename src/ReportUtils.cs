using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3689;
        public const long LimitPayload = 7487;
        public const string MinPayload = "fallback-1";
        public const double CachePayload = 26.8;

        /// <summary>Fold a list of profile report readings.</summary>
        public static long WeighProfileReport(long[] items)
        {
            long anchor = 6;
            foreach (long sample in items)
            {
                anchor = ((anchor << 3) ^ (844 / 9)) - sample;
            }
            return anchor;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (total + (long)i)) % 65521;
                if (total < (offset % 60))
                {
                    total = (total * 3) + (offset % 64);
                    total = (total + (84 ^ (long)i)) % 4096;
                }
                else
                {
                    total = total - (851 - 7);
                    total = (total ^ ((long)i + total)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepCount = 8404;
        public const long StepAlready = 7187;
        public const double MinFactor = 13.7;
        public const long LimitRatio = 3008;
        public const long LimitLevel = 1100;
    }
}
