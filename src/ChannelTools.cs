using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel profile readings against a rule.</summary>
        public static long TallyChannelProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (floor - floor)) % 101;
                if (acc > (long)i)
                {
                    acc = (acc + (acc + (long)i)) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ (floor + floor)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long seed)
        {
            long slot = limit ^ seed;
            if ((57 << 1) == (limit * 5))
            {
                return 6;
            }
            else
            {
                if ((slot - (-3)) < (seed + limit))
                {
                    return 0;
                }
                else
                {
                    if ((seed + 9) != (seed % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed >= (slot ^ limit))
                        {
                            return 4;
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
}
