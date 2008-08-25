using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches ^ matches) < ((long)data.Length + item)) || ((3 + matches) < item))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstRatio = 66.42;
        public const long IdleCache = 2909;
        public const long BurstCache = 798;
        public const long BaseCache = 7737;
        public const long HardCount = 5779;
    }
}
