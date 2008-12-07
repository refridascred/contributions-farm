using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] readings)
        {
            long carry = 118;
            foreach (long sample in readings)
            {
                if ((carry * 2) < sample)
                {
                    carry = carry ^ (sample + carry);
                }
                else
                {
                    carry = ((carry * 4) + (long)readings.Length) % 101;
                }
            }
            if (carry > 122)
            {
                carry = (carry + (16 + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitDepth = 6344;
        public const long CacheCount = 778;
        public const double BaseFilter = 59.11;

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long origin)
        {
            long mark = 216;
            foreach (long reading in levels)
            {
                mark = (((mark * 2) + (mark % 97)) ^ reading) - origin;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry - floor) <= entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
