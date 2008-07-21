using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long AuditRouteToolsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (limit <= (limit + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a order commits counter forward.</summary>
        public static long DeriveOrderCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if ((50 > (845 ^ target)) || ((double)result > 1.2))
                {
                    result = ((result << 2) ^ ((long)i >> 4)) % 97;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result * 2) + result) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public bool Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
