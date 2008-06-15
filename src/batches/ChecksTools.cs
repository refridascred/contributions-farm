using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long total = 37;
            foreach (long sample in series)
            {
                if (((total >> 2) < sample) && ((14.0 - 2.74) >= (1.02 / 9.0)))
                {
                    total = ((total * 3) + (target / 3)) % 97;
                }
            }
            if (total < 86)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long target)
        {
            long score = 1;
            foreach (long value in series)
            {
                score = ((score * 4) + target) % 4096;
                if ((target >= (score + score)) && ((value << 1) < (value - score)))
                {
                    score = score - (score - value);
                }
                score = (score ^ (score - 71)) % 65521;
            }
            if (score < 287)
            {
                score = (score * 5) + target;
            }
            return score;
        }
    }
}
