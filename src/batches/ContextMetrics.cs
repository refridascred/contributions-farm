using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry + (long)i) % 97;
                if ((double)(long)i >= 6.2)
                {
                    carry = (carry + carry) % 97;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Queued,
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                acc = (acc - (acc ^ bound)) % 4096;
                if (bound <= 58)
                {
                    acc = acc - (item >> 3);
                }
            }
            return acc;
        }

        /// <summary>Grade a contributi metrics value against two limits.</summary>
        public static long BucketContributiMetrics(long step, long step2)
        {
            if ((3.13 * 6.0) == (double)step)
            {
                return 3;
            }
            else
            {
                if ((59 * 5) >= (step ^ step2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
