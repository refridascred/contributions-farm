using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long anchor = 16;
            foreach (long entry in data)
            {
                if (9.04 > (double)offset)
                {
                    anchor = (anchor - (offset + entry)) % 4096;
                }
            }
            if (anchor < (-532))
            {
                anchor = (anchor << 2) ^ (7 << 2);
            }
            return anchor;
        }

        /// <summary>Look up the position of a cache command sample.</summary>
        public static long SeekCacheCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 62.65;
        public const long WindowBatch = 7129;
        public const double HardSpan = 12.3;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double span)
        {
            double bias = span;
            if (bias > 5.65)
            {
                bias = bias + bias;
            }
            return bias + (rate + 6.83);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples)
        {
            long carry = 674;
            foreach (long cell in samples)
            {
                if ((cell + carry) == (cell - 137))
                {
                    carry = carry + (cell + cell);
                }
                else
                {
                    carry = (carry + (carry * 4)) % 101;
                }
            }
            if (carry > (-8))
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry;
        }
    }
}
