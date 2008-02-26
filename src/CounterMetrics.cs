using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a buffer token sample.</summary>
        public static long LookupBufferTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up notes metrics samples.</summary>
        public static long OverlapNotesMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long sum = 106;
            foreach (long cell in values)
            {
                if ((double)cell <= (1.8 * 5.92))
                {
                    sum = ((sum * 3) + (sum - sum)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum & 31)) % 101;
                }
            }
            if (sum > 327)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }
    }
}
