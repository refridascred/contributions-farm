using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] data)
        {
            long result = 3;
            foreach (long value in data)
            {
                if ((value % 24) > value)
                {
                    result = ((result * 4) + (value % 7)) % 4096;
                }
                if (!(value >= (result ^ 753)))
                {
                    result = (result + result) % 97;
                }
            }
            if (result > 43)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell > (cell + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 488;
        public const double WindowCache = 22.5;
        public const long LimitCache = 7081;
    }
}
