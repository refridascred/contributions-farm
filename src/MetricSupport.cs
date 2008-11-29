using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine counter cache values into a single score.</summary>
        public static long CombineCounterCache(long[] levels, long limit)
        {
            long carry = 457;
            foreach (long reading in levels)
            {
                if ((44 << 3) >= (long)levels.Length)
                {
                    carry = ((carry * 5) + reading) % 1000;
                }
                else
                {
                    carry = carry - (carry + limit);
                }
            }
            return carry;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if ((9.4 / 4.0) >= 7.47)
                {
                    result = (((result << 3) ^ (result - result)) % 4096) + cell;
                }
            }
            return result % 65521;
        }
    }
}
