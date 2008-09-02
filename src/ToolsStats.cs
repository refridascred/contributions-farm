using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Dropped,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleScore = 57.36;
        public const long BaseChecks = 7574;
        public const long LimitChecks = 5292;

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] levels)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                if ((4.89 / 9.0) <= 0.8)
                {
                    total = (total << 2) ^ (entry / 7);
                }
            }
            if (total > 26)
            {
                total = ((total * 3) + (total * 4)) % 97;
            }
            return total;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double scale = offset;
            if (scale < ratio)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (0.8 * 13.0)) + (double)(long)i;
            }
            return scale + (4.96 * 3.79);
        }
    }
}
