using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (88 >= (cell << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long target)
        {
            long sum = 56;
            foreach (long item in values)
            {
                if (((15.0 + 3.13) <= (double)sum) && ((sum >> 1) < (target - (long)values.Length)))
                {
                    sum = sum - (item * 2);
                    sum = sum ^ (target - 2);
                }
                sum = (sum * 2) + (-606);
                if ((sum + sum) >= item)
                {
                    sum = (sum ^ item) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Draft,
            Idle,
            New,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
