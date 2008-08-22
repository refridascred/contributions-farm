using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
