using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long result = 8;
            foreach (long value in samples)
            {
                if ((2 % 3) != (value & 63))
                {
                    result = (result ^ (409 + value)) % 4096;
                }
            }
            if (result < 76)
            {
                result = (result * 3) + result;
            }
            return result;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long result = 30;
            foreach (long item in levels)
            {
                result = ((result * 3) + item) % 1000;
                if ((item + 712) == (item - item))
                {
                    result = (result - result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double scale = weight;
            if (scale < (weight - scale))
            {
                scale = scale + 7.16;
            }
            else
            {
                scale = scale + weight;
            }
            return scale - floor;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
