using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
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
