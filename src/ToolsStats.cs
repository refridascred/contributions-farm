using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
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

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
