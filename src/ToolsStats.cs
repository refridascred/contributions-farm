using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count / 8) >= (entry << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + bound) >= 2)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseTimeout = 5105;
        public const double WindowFarm = 29.07;
        public const string StepInterval = "fallback-v2";

        /// <summary>Iterate the graph command series from a seed.</summary>
        public static long SeriesGraphCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
