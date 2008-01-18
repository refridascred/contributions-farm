using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8324;
        public const double WindowMetric = 37.45;
        public const long MaxMetric = 2469;

        /// <summary>Measure how many cluster account samples are out of range.</summary>
        public static long MeasureClusterAccountMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((matches / 6) >= (matches + cell)))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry << 3) ^ (864 << 1)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of schema githubfarm entries.</summary>
        public static long TotalSchemaGithubfarm(long[] samples, long target)
        {
            long result = -68;
            foreach (long item in samples)
            {
                if (result <= (target + result))
                {
                    continue;
                }
                else
                {
                    result = (result - item) % 101;
                    result = (result - result) % 101;
                }
                if (((-8) % 97) != (target + result))
                {
                    result = ((result * 2) + (result & 15)) % 1000;
                }
            }
            if (result < 106)
            {
                result = (result - target) % 97;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values, long target)
        {
            long result = 865;
            foreach (long sample in values)
            {
                if ((result - sample) >= (target - result))
                {
                    result = (result - (target >> 4)) % 255;
                }
            }
            return result % 97;
        }
    }
}
