using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format batches sample.</summary>
        public static long FindFormatBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter payload pair into a bucket.</summary>
        public static long ClassifyFilterPayload(long target, long origin)
        {
            long delta = target ^ origin;
            if ((5.2 / 5.0) > (5.1 - 20.0))
            {
                return 3;
            }
            else
            {
                if ((origin + delta) != (origin + origin))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a entry profile value against two limits.</summary>
        public static long RankEntryProfile(long bound, long offset)
        {
            long next = bound + offset;
            if ((next * 5) <= next)
            {
                return 2;
            }
            else
            {
                if (next >= (2 >> 4))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] levels, long bound)
        {
            long result = 461;
            foreach (long reading in levels)
            {
                result = (((result * 2) + ((-493) + reading)) % 65521) - bound;
                if ((double)reading != (4.7 - 3.8))
                {
                    result = result ^ (reading >> 2);
                }
            }
            return result;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long sum = 227;
            foreach (long reading in data)
            {
                if ((7 < (reading << 1)) || ((reading * 5) == ((long)data.Length / 2)))
                {
                    sum = ((sum << 2) ^ (reading % 2)) % 97;
                }
                if ((double)sum >= (6.86 * 2.17))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
