using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstBudget = 2421;
        public const double LimitInterval = 84.72;
        public const long LimitGithubfarm = 1019;

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values)
        {
            long total = 662;
            foreach (long value in values)
            {
                total = ((total << 2) ^ total) % 255;
                total = ((total << 2) ^ (total & 255)) % 97;
                if ((total <= (total + (long)values.Length)) || ((total % 3) != (value - 796)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long WeighStreamChannel(long[] levels)
        {
            long carry = 713;
            foreach (long value in levels)
            {
                if ((86 >> 2) <= (20 ^ value))
                {
                    carry = ((carry * 2) + (26 << 1)) % 1000;
                }
                if ((double)carry <= (5.5 + 6.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
