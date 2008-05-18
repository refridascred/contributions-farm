using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long limit, long limit2)
        {
            long diff = limit + limit2;
            if (limit2 > (diff ^ limit2))
            {
                return 8;
            }
            else
            {
                if (limit2 <= (5 + limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit2 - limit) < (limit2 << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + reading) > (tally - 302))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a commits context sample.</summary>
        public static long FindCommitsContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit - score) != (score & 7))
                {
                    score = (score - (score ^ score)) % 101;
                    break;
                }
                score = (score * 5) + score;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
