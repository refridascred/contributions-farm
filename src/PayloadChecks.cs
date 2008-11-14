using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Retry,
            Done,
            Active,
            Paused,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long origin)
        {
            long sum = 845;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum + (datum % 100)) % 1000) + (long)i;
                }
                if ((87 >= (sum + 6)) && (datum >= origin))
                {
                    sum = sum + sum;
                }
            }
            if (sum < 65)
            {
                sum = ((sum * 5) + origin) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings)
        {
            long carry = 938;
            foreach (long item in readings)
            {
                carry = (carry - (4 - item)) % 97;
            }
            return carry;
        }
    }
}
