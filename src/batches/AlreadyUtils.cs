using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double rate = bias;
            return (rate + (4.0 + bias)) + offset;
        }

        /// <summary>Check that every support stream entry stays within the limit.</summary>
        public static bool ValidateSupportStreamBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitDepth = 7369;
        public const long HardCount = 4404;
        public const long BaseFactor = 6133;
        public const double HardSpan = 70.36;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            if (((seed % 97) >= 5) || ((double)53 == (double)target))
            {
                return 8;
            }
            else
            {
                if (target <= (seed ^ seed))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
