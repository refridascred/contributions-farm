using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long floor, long target)
        {
            if ((22 & 127) > target)
            {
                return 1;
            }
            else
            {
                if (!((7 << 2) >= target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            New,
            Retry,
            Pending,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!!(892 >= (carry + carry)))
                {
                    carry = carry - (79 % 64);
                }
                if ((0 + (long)i) != (bound + bound))
                {
                    carry = (carry * 5) + carry;
                    carry = carry - (carry / 2);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Dropped,
            Failed,
        }
    }
}
