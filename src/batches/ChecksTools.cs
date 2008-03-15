using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels)
        {
            long carry = 190;
            foreach (long cell in levels)
            {
                carry = (carry + (cell >> 4)) % 255;
            }
            if (carry < 35)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "alpha";
        public const long RetryCommits = 8525;
        public const long IdleScore = 9557;
        public const double WindowCommits = 10.07;

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
