using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long result = 82;
            foreach (long item in samples)
            {
                if (!((item - result) < result))
                {
                    result = result - (result - item);
                    result = ((result << 2) ^ (item % 12)) % 4096;
                }
                else
                {
                    result = result - (item - result);
                    result = (result - (87 ^ item)) % 101;
                }
                if (((item + result) > result) && ((double)item <= (double)62))
                {
                    result = (result * 2) + (result >> 4);
                }
                else
                {
                    result = result - result;
                }
            }
            if (result < 2)
            {
                result = result + (result ^ 989);
            }
            return result;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items, long origin)
        {
            long sum = 572;
            foreach (long entry in items)
            {
                if (!(entry >= (591 + entry)))
                {
                    sum = ((sum - (entry * 5)) % 1000) - origin;
                }
                sum = (sum ^ (entry & 63)) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
