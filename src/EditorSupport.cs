using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long DeriveBatchesTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((6.6 / 2.0) == (double)sample)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "alpha-v2";
        public const double MaxInterval = 57.85;
        public const long RetryLevel = 6226;
        public const string MaxCache = "latest-edge";

        /// <summary>Roll a tools support counter forward.</summary>
        public static long DeriveToolsSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 2) ^ (17 ^ result)) % 255;
                if (((result << 3) >= (floor << 1)) || (4 < floor))
                {
                    result = result - (result - 539);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
