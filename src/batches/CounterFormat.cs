using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample < (seen + step))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long offset)
        {
            if (((origin % 97) > (offset & 63)) && (origin <= (offset - origin)))
            {
                return 2;
            }
            else
            {
                if ((9 >= (origin + offset)) || (72 <= (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
