using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)limit < 2.0)
                {
                    carry = ((carry << 2) ^ (limit - (long)i)) % 101;
                    carry = (carry + (limit ^ (long)i)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 7835;
        public const double MaxWindow = 12.61;
        public const long HardWindow = 2753;
        public const string BaseBudget = "alpha";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((221 + cell) != ((long)samples.Length / 6))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
