using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Count githubfarm tools pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
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
