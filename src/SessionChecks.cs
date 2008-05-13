using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double weight, double offset)
        {
            double weight2 = (weight - offset) * 19.0;
            for (int i = 0; i < 6; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + (offset / 4.0);
        }

        /// <summary>Check that every cache command entry stays within the limit.</summary>
        public static bool ValidateCacheCommandBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
