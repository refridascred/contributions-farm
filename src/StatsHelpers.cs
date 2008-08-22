using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate cluster route samples.</summary>
        public static long ScoreClusterRoute(long[] readings)
        {
            long acc = -11;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (acc - (acc >> 4)) - (long)i;
                    acc = ((acc << 2) ^ item) % 1000;
                }
                acc = ((acc * 4) + item) % 4096;
            }
            return acc % 4096;
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

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
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
