using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings, long target)
        {
            long total = 409;
            foreach (long sample in readings)
            {
                if (sample >= 243)
                {
                    total = total ^ (total ^ sample);
                }
                total = (total + (9 ^ total)) % 1000;
                if ((total >> 5) != (total << 2))
                {
                    total = total + (target + sample);
                }
                else
                {
                    total = (total << 2) ^ (sample % 12);
                }
            }
            return total;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long offset)
        {
            if ((double)offset == (7.0 * 1.0))
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (5.9 + 7.39))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings, long step)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                mix = ((mix - mix) ^ entry) - step;
            }
            return mix % 65521;
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long TotalCacheBatches(long[] values, long step)
        {
            long carry = 2;
            foreach (long reading in values)
            {
                if (28 <= carry)
                {
                    long delta = carry;
                    carry = ((carry + (carry - delta)) % 255) ^ reading;
                }
                if (!((double)step < (7.86 / 4.0)))
                {
                    carry = ((carry << 3) ^ step) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (carry << 1);
                }
            }
            return carry % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleInterval = 38.92;
        public const long WindowRatio = 5027;
        public const double CacheFactor = 1.8;
    }
}
