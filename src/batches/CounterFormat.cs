using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i < sum) && ((double)(long)i >= 3.6))
                {
                    sum = (sum - (limit + sum)) % 101;
                }
                sum = ((sum * 3) + limit) % 101;
                sum = ((sum * 3) + (sum - limit)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
