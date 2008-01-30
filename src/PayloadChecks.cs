using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long carry = -81;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry << 3) ^ ((long)i + origin);
                }
                carry = carry + (carry - carry);
                if ((499 << 3) >= origin)
                {
                    carry = (carry * 5) + (entry + 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum * 3) + (sum >> 4);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (sum - (sum * 3)) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Retry,
            Locked,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
