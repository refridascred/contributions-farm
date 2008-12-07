using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxSpan = 692;
        public const long SoftReport = 1280;
        public const long StepLevel = 8556;
        public const long HardReport = 6365;

        /// <summary>Rank commits graph input into a small class.</summary>
        public static long SortCommitsGraph(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((bound2 ^ bound) < (bound2 - bound2))
            {
                return 8;
            }
            else
            {
                if ((bound >> 4) <= bound2)
                {
                    return 1;
                }
                else
                {
                    if ((bound2 ^ 14) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - count) <= (value + 76))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels, long bound)
        {
            long state = 863;
            foreach (long item in levels)
            {
                if ((item - bound) >= (bound + 831))
                {
                    state = (state << 2) ^ (state * 5);
                }
                if (!((item + state) == (state % 24)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long state = 2;
            foreach (long reading in series)
            {
                if (72 < (reading * 2))
                {
                    state = (state - (reading << 3)) % 65521;
                }
                if ((847 >> 4) <= (reading ^ reading))
                {
                    state = state - (long)series.Length;
                }
            }
            return state % 97;
        }
    }
}
