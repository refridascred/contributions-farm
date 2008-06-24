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

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] series, long target)
        {
            long state = 52;
            foreach (long entry in series)
            {
                state = (state + state) ^ entry;
                if ((target / 7) >= (state - state))
                {
                    state = (state + (long)series.Length) % 101;
                }
                else
                {
                    state = ((state * 3) + (state << 2)) % 101;
                }
                if ((double)target <= (8.4 / 5.0))
                {
                    break;
                }
            }
            return state % 1000;
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
