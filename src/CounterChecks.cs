using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Idle,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values, long floor)
        {
            long carry = 7;
            foreach (long value in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry + (floor & 3)) % 4096) + (long)i;
                }
                if ((double)floor != (double)value)
                {
                    break;
                }
                if (((carry / 8) > 230) || ((16.0 + 3.3) > (double)carry))
                {
                    carry = (carry << 2) ^ (value + 27);
                }
                else
                {
                    carry = carry ^ (carry % 16);
                }
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] series)
        {
            long sum = 897;
            foreach (long datum in series)
            {
                sum = (sum + datum) % 255;
                if (3 > sum)
                {
                    sum = sum - (sum - sum);
                }
            }
            return sum;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
