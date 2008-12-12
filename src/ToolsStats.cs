using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine queue channel values into a single score.</summary>
        public static long TotalQueueChannel(long[] samples, long seed)
        {
            long score = 0;
            foreach (long sample in samples)
            {
                if (seed >= (score & 127))
                {
                    score = ((score - (score + seed)) % 97) ^ sample;
                }
            }
            if (score < 337)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double ratio = 20.0 * 1.86;
            if (ratio >= bias)
            {
                ratio = (ratio + 4.1) + bias2;
            }
            else
            {
                ratio = ratio - (bias - 1.89);
            }
            return ratio - bias;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryBudget = 42.42;
        public const string RetryFormat = "alpha";
        public const long MinFormat = 3858;

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                carry = (((carry * 3) + (carry ^ 70)) % 101) + item;
            }
            return carry % 65521;
        }
    }
}
