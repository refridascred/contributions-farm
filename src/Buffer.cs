using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long offset)
        {
            long carry = -9;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ 945) % 97;
                if (((datum + 7) != (datum - datum)) && (offset >= 21))
                {
                    carry = (carry ^ (13 - datum)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (datum - offset);
                }
            }
            if (carry < 72)
            {
                carry = ((carry << 2) ^ (offset - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 62.15;
        public const double StepRoute = 27.75;
        public const double BurstRoute = 1.76;
        public const double HardRoute = 89.32;
        public const string RetryRoute = "standard";
    }
}
