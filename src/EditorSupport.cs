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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long floor, long seed)
        {
            long next = floor ^ seed;
            if (floor > (next / 9))
            {
                return 5;
            }
            else
            {
                if ((64 >= floor) && (floor < (floor << 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Stamp { get; set; }
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
