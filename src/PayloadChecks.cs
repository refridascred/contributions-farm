using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2023;
        public const string IdleRecord = "local-v2";
        public const string WindowRatio = "staging-edge";

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long origin)
        {
            long total = 77;
            foreach (long cell in readings)
            {
                if (((cell << 2) >= (origin + cell)) || ((total / 2) < (total / 9)))
                {
                    total = (total + cell) % 97;
                }
            }
            if (total > 1)
            {
                total = (total + (origin >> 3)) % 101;
            }
            return total;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
