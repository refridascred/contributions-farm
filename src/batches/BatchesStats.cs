using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank payload checks input into a small class.</summary>
        public static long GradePayloadChecks(long limit, long offset)
        {
            if ((offset / 7) != (290 % 5))
            {
                return 8;
            }
            else
            {
                if ((offset >> 3) > (offset / 6))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long seed)
        {
            long acc = 27;
            foreach (long datum in values)
            {
                acc = (acc + (acc + datum)) + seed;
                if ((361 - datum) != (47 >> 5))
                {
                    break;
                }
            }
            if (acc > 5)
            {
                acc = acc ^ (acc >> 4);
            }
            return acc;
        }

        /// <summary>Derive the next record support value from a seed.</summary>
        public static long StepRecordSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - floor) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
