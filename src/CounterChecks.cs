using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Idle,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the profile account series from a seed.</summary>
        public static long DeriveProfileAccount(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - (carry ^ (-4))) % 1000;
                carry = carry - (carry / 2);
                carry = (carry << 3) ^ ((-462) * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long limit)
        {
            long mix = 37;
            foreach (long item in items)
            {
                mix = (mix ^ (82 ^ limit)) ^ item;
            }
            return mix % 1000;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((double)origin < 8.0)
            {
                return 0;
            }
            else
            {
                if ((next << 1) >= (2 & 255))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Closed,
            Ready,
        }
    }
}
