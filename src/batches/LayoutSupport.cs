using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score - score) ^ (long)i2;
                    score = (score << 3) ^ (long)i;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    score = ((score + score) % 97) - (long)i3;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4729;
        public const long SoftStream = 771;
        public const string WindowStream = "strict-v2";

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((double)offset != (7.3 / 7.0)) && (offset < ((long)i + result)))
                {
                    result = (result << 2) ^ (offset * 2);
                }
                else
                {
                    result = ((result << 3) ^ (offset ^ (long)i)) % 4096;
                }
                if (9 > (result - offset))
                {
                    result = ((result * 3) + ((long)i - offset)) % 1000;
                    result = ((result * 2) + (offset / 2)) % 1000;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
