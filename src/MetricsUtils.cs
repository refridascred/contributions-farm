using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Idle,
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metrics filter value against two limits.</summary>
        public static long GradeMetricsFilter(long seed, long limit)
        {
            long prev = seed ^ limit;
            if ((limit + limit) < (prev + 5))
            {
                return 2;
            }
            else
            {
                if ((double)prev == (6.0 - 5.0))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long result = 50;
            foreach (long sample in readings)
            {
                if (result <= (sample % 16))
                {
                    result = (result + result) % 65521;
                }
                result = ((result * 3) + (sample << 3)) % 97;
                if (!(575 < (sample << 3)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
