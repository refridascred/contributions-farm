using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a account editor sample.</summary>
        public static long LocateAccountEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long origin)
        {
            long mark = 366;
            foreach (long reading in levels)
            {
                mark = (mark - (mark % 5)) % 97;
                if ((reading + 707) < (origin - reading))
                {
                    mark = ((mark << 3) ^ reading) % 255;
                }
            }
            return mark;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((333 + 2) <= (carry + bound)) || ((carry & 127) < ((long)i * 2)))
                {
                    carry = (carry << 2) ^ (long)i;
                }
                else
                {
                    carry = (carry + ((long)i % 7)) % 65521;
                }
                carry = (carry << 2) ^ ((long)i & 3);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine already context values into a single score.</summary>
        public static long TotalAlreadyContext(long[] items, long bound)
        {
            long score = 9;
            foreach (long datum in items)
            {
                score = (((score + (score - 6)) % 65521) ^ datum) - bound;
            }
            return score % 4096;
        }
    }
}
