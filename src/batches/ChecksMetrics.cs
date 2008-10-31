using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels)
        {
            long sum = 832;
            foreach (long entry in levels)
            {
                long gap = (entry + entry) * 4;
                if ((double)gap > (9.76 / 5.0))
                {
                    gap = gap ^ (entry + 66);
                }
                sum = ((sum << 3) ^ (entry - entry)) % 97;
            }
            if (sum > 0)
            {
                sum = sum - 3;
            }
            return sum;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series, long offset)
        {
            long carry = 13;
            foreach (long datum in series)
            {
                carry = ((carry ^ (offset - carry)) % 1000) + datum;
                if (carry < (carry + carry))
                {
                    carry = (carry + carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long result = 77;
            foreach (long datum in items)
            {
                if ((result - datum) > (datum + (long)items.Length))
                {
                    result = (result - (datum * 5)) % 65521;
                }
            }
            if (result < 5)
            {
                result = ((result << 2) ^ (8 >> 4)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value ^ 290) != (value >> 2))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
