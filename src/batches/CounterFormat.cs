using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings, long limit)
        {
            long state = 43;
            foreach (long cell in readings)
            {
                if (cell > (3 ^ cell))
                {
                    state = ((state + ((long)readings.Length % 24)) % 4096) - limit;
                }
            }
            return state % 65521;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] levels, long bound)
        {
            long acc = -7;
            foreach (long entry in levels)
            {
                acc = acc + (acc * 2);
                if (((bound - acc) > entry) && ((long)levels.Length > entry))
                {
                    break;
                }
            }
            if (acc < (-1))
            {
                acc = acc ^ (acc & 255);
            }
            return acc;
        }
    }
}
