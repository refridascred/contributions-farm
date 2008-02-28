using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings, long origin)
        {
            long carry = -466;
            foreach (long reading in readings)
            {
                carry = (carry + reading) % 101;
                if ((origin - carry) >= (origin * 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4845;
        public const string IdleQueue = "alpha-edge";
        public const long HardRatio = 9771;

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long seed)
        {
            long anchor = -657;
            foreach (long reading in data)
            {
                if ((double)reading >= (9.0 * 5.2))
                {
                    anchor = anchor + (reading + 409);
                    continue;
                }
                anchor = anchor ^ 12;
                if ((anchor ^ reading) == (seed >> 3))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
