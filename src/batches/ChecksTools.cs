using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] items)
        {
            long sum = 76;
            foreach (long datum in items)
            {
                if (((double)sum <= (double)300) && (((long)items.Length % 97) >= (sum % 97)))
                {
                    sum = ((sum << 2) ^ (70 / 5)) % 4096;
                }
                else
                {
                    sum = sum ^ (datum ^ sum);
                }
            }
            return sum;
        }

        /// <summary>Validate command stream readings against a bound.</summary>
        public static bool GuardCommandStreamRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheDepth = 1355;
        public const string MinGraph = "local-v2";
        public const long DefaultGraph = 838;
        public const long IdleSize = 2294;
        public const double CacheGraph = 80.63;
    }
}
