using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 43;
            foreach (long value in series)
            {
                if ((value & 63) >= (acc & 255))
                {
                    acc = ((acc << 3) ^ (value + value)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc >> 4)) % 101;
                }
            }
            if (acc > 93)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
