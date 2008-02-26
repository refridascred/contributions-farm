using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((result + origin) < (result >> 3)) || ((origin & 127) == (origin << 3)))
                {
                    result = ((result * 3) + 59) % 255;
                    continue;
                }
                else
                {
                    result = (result - (result - (long)i)) % 255;
                    result = (result - origin) % 65521;
                }
                if (((result % 24) <= ((long)i + origin)) && (((long)i * 5) < (result << 2)))
                {
                    result = ((result * 4) + (result - (long)i)) % 65521;
                }
                else
                {
                    result = (result * 2) + (result - (long)i);
                    result = result - (long)i;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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
