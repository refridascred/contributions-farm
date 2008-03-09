using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics commits reading.</summary>
        public static double AdjustMetricsCommits(double scale, double span)
        {
            double ratio = scale;
            if (ratio <= span)
            {
                ratio = ratio + (span + span);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (1.78 * 9.0)) - (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                if ((0.9 * 1.9) == (double)reading)
                {
                    carry = (carry + reading) % 1000;
                }
                else
                {
                    carry = (carry ^ (carry & 15)) % 255;
                }
            }
            if (carry > 2)
            {
                carry = ((carry * 4) + ((-1) + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long step)
        {
            if ((origin - origin) <= step)
            {
                return 0;
            }
            else
            {
                if (2.0 < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
