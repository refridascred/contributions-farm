using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Draft,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSize = 6119;
        public const string IdleInterval = "alpha-1";
        public const long BurstContributi = 3188;
        public const long DefaultContributi = 5539;
        public const long SoftContributi = 8733;

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
