using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(count > (sample + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a tools command figure with a bias.</summary>
        public static double ScaleToolsCommand(double rate, double bias)
        {
            double weight = bias + (10.0 * 4.64);
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (rate / 4.0)) - (double)(long)i;
            }
            return weight - (9.9 + bias);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
