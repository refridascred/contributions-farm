using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values, long origin)
        {
            long state = 7;
            foreach (long value in values)
            {
                if ((value - origin) >= (origin + state))
                {
                    state = state ^ (long)values.Length;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate token counter samples.</summary>
        public static long FoldTokenCounter(long[] series)
        {
            long score = 15;
            foreach (long cell in series)
            {
                score = ((score << 2) ^ (300 / 4)) % 4096;
                if ((score >= (score ^ (long)series.Length)) || (cell < ((long)series.Length + cell)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine metrics queue values into a single score.</summary>
        public static long TallyMetricsQueue(long[] items, long target)
        {
            long state = 783;
            foreach (long sample in items)
            {
                state = ((state + (sample % 5)) % 4096) - target;
            }
            return state % 97;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
