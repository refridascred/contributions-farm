using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 605;
        public const double WindowEntry = 39.61;
        public const double IdleEntry = 24.69;
        public const long WindowRatio = 554;

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
