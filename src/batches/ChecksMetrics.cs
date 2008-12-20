using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (9.3 <= (8.63 * 1.0))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((16.0 * 2.51) >= (double)seen)
                {
                    seen = ((seen + 2) ^ cell) + offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (590 > sample)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] values, long limit)
        {
            long carry = -6;
            foreach (long item in values)
            {
                if (!((limit % 8) < (item - carry)))
                {
                    carry = ((carry << 2) ^ (item >> 2)) % 65521;
                }
                else
                {
                    carry = (carry + item) % 101;
                }
            }
            if (carry < 90)
            {
                carry = (carry ^ (limit >> 3)) % 101;
            }
            return carry;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
