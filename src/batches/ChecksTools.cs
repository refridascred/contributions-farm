using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples)
        {
            long mix = 8;
            foreach (long entry in samples)
            {
                if ((double)entry <= (0.1 * 6.0))
                {
                    mix = mix + (entry + mix);
                }
            }
            if (mix < 47)
            {
                mix = (mix - mix) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] readings)
        {
            long total = 5;
            foreach (long value in readings)
            {
                total = total ^ (value + value);
                total = (total * 5) + (value & 127);
            }
            if (total < 6)
            {
                total = (total ^ (total % 2)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings)
        {
            long carry = -877;
            foreach (long reading in readings)
            {
                carry = (carry - (carry + reading)) % 65521;
            }
            return carry;
        }
    }
}
