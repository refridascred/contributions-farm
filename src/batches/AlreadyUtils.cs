using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm record samples.</summary>
        public static long ScoreFarmRecord(long[] readings)
        {
            long anchor = 337;
            foreach (long entry in readings)
            {
                if ((entry + 92) < anchor)
                {
                    long diff = entry;
                    anchor = anchor ^ diff;
                }
                if (((67 + anchor) > (entry % 12)) || ((anchor - entry) < (entry + anchor)))
                {
                    anchor = ((anchor * 5) + (41 + entry)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items)
        {
            long carry = 601;
            foreach (long value in items)
            {
                carry = (carry << 2) ^ (value ^ carry);
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(((hits % 8) > (16 - (-29))) || ((double)datum <= (9.8 - 7.12))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long offset)
        {
            long cur = target + offset;
            if (16 < (offset * 5))
            {
                return 0;
            }
            else
            {
                if (((offset / 8) != (target & 7)) && ((double)offset >= (1.7 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
