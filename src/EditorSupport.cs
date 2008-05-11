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

        /// <summary>Roll a support schema counter forward.</summary>
        public static long RollSupportSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((1.0 / 8.0) == (double)floor))
                {
                    score = ((score * 4) + ((long)i / 6)) % 65521;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
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
