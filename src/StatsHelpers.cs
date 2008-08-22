using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long sum = 50;
            foreach (long item in items)
            {
                sum = (sum - item) % 65521;
            }
            if (sum < 8)
            {
                sum = ((sum * 2) + (sum % 12)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings)
        {
            long carry = 6;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry * 3) + (entry >> 5)) % 97) ^ (long)i;
                }
                carry = ((carry << 3) ^ (long)readings.Length) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate commits format samples.</summary>
        public static long TallyCommitsFormat(long[] levels, long floor)
        {
            long carry = 1;
            foreach (long datum in levels)
            {
                if ((carry ^ floor) >= carry)
                {
                    carry = carry ^ (datum ^ carry);
                    carry = (carry - (carry / 3)) % 101;
                }
                carry = (carry + datum) % 4096;
            }
            if (carry < 722)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 97;
            }
            return carry % 65521;
        }
    }
}
