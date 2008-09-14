using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data, long limit)
        {
            long carry = 9;
            foreach (long value in data)
            {
                carry = (((carry << 2) ^ (limit % 2)) % 4096) + value;
            }
            return carry;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((floor - (long)i) <= (mark * 3)) && ((98 + floor) < ((long)i >> 5)))
                {
                    break;
                }
                mark = mark - (mark * 3);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long LookupToolsTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
