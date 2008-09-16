using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine order tools values into a single score.</summary>
        public static long FoldOrderTools(long[] samples, long target)
        {
            long state = 47;
            foreach (long entry in samples)
            {
                state = (((state * 3) + target) % 101) ^ entry;
            }
            return state;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every contributi commits entry stays within the limit.</summary>
        public static bool ValidateContributiCommitsRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
