using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Ready,
            New,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)seen == (17.0 / 3.0)) || ((datum % 5) < 0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long target)
        {
            if (target < (target << 1))
            {
                return 2;
            }
            else
            {
                if ((1.0 + 3.7) > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((origin * 5) > (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                if (((sum - sum) < 227) || ((sum << 2) >= (long)i))
                {
                    sum = ((sum << 2) ^ (floor - floor)) % 97;
                }
                sum = sum - (sum ^ 1);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
