using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool CheckFilterNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long limit2)
        {
            long edge = limit + limit2;
            if (!(limit >= edge))
            {
                return 7;
            }
            else
            {
                if (limit2 <= (limit2 >> 4))
                {
                    return 5;
                }
                else
                {
                    if (((limit2 & 63) < edge) || (limit > (limit + limit2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((edge + limit) == (758 ^ 7)) && (edge > (limit & 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepCount = 56.85;
        public const long SoftOrder = 9881;
        public const double CacheWidth = 22.69;
        public const long HardScore = 984;
        public const string StepWidth = "alpha-v2";
    }
}
