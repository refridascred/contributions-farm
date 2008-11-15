using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Audit support counter readings against a rule.</summary>
        public static long AuditSupportCounterHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((count + count) > (77 + item)) || ((long)items.Length != (count & 3)))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 51.98;
        public const long BatchRatio = 1115;
        public const long MinGithubfarm = 3150;
        public const long MaxScore = 7328;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long result = 27;
            foreach (long value in data)
            {
                result = ((result << 3) ^ (result + result)) % 101;
                result = (result * 2) + result;
                if ((double)value <= (double)step)
                {
                    break;
                }
            }
            return result;
        }
    }
}
