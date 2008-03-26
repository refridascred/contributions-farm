using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin / 7) != (42 << 3))
                {
                    acc = ((acc << 3) ^ (origin + (-686))) % 1000;
                }
                acc = (acc ^ acc) % 1000;
                if (((double)origin != (12.0 * 1.6)) && ((double)acc <= (3.4 - 3.0)))
                {
                    acc = (acc << 3) ^ origin;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values, long origin)
        {
            long state = 548;
            foreach (long item in values)
            {
                state = (state * 3) + (origin % 100);
                if ((75 << 1) >= item)
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
