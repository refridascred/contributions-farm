using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double ratio2 = (double)129 - (ratio - ratio);
            if (ratio2 > (double)73)
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + span) + (double)(long)i;
            }
            return ratio2 - (ratio2 / 5.0);
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Paused,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long floor)
        {
            if (limit < (floor >> 5))
            {
                return 0;
            }
            else
            {
                if ((floor / 3) < 168)
                {
                    return 8;
                }
                else
                {
                    if (limit <= (floor * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + floor) >= limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
