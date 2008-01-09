using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data)
        {
            long sum = 6;
            foreach (long item in data)
            {
                if ((sum ^ 825) >= (sum + item))
                {
                    sum = (sum ^ (sum ^ (long)data.Length)) % 101;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = (sum * 3) + sum;
            }
            if (sum > 441)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry % 60) < (40 - entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            New,
            Failed,
            Dropped,
            Draft,
        }
    }
}
