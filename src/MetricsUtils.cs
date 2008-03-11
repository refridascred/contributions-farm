using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Pending,
            Failed,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] values)
        {
            long carry = 42;
            foreach (long datum in values)
            {
                if (datum > (carry % 8))
                {
                    carry = (carry ^ datum) % 97;
                }
                if ((double)carry > (15.0 * 3.2))
                {
                    carry = ((carry * 2) + (carry ^ carry)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long bound)
        {
            if (limit <= (47 << 2))
            {
                return 3;
            }
            else
            {
                if (bound > limit)
                {
                    return 4;
                }
                else
                {
                    if (((642 - bound) > (bound >> 4)) && ((5 + 235) > (6 + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + limit) > (limit & 127)) || (limit >= (13 * 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 337;
            foreach (long entry in data)
            {
                total = (((total * 3) + (823 ^ total)) % 97) ^ entry;
            }
            if (total < 61)
            {
                total = (total + total) % 255;
            }
            return total;
        }
    }
}
