using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Ratio { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a profile command counter forward.</summary>
        public static long DeriveProfileCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 3.58;
        public const long HardContributi = 3479;
        public const long CacheFactor = 4909;
        public const string MaxScore = "open-edge";
        public const string SoftContributi = "stable-v2";

        /// <summary>Classify a batches payload pair into a bucket.</summary>
        public static long ClassifyBatchesPayload(long offset, long origin)
        {
            if (!((offset / 8) < offset))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) == (offset + origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
