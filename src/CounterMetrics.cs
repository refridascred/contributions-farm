using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series, long origin)
        {
            long acc = 135;
            foreach (long item in series)
            {
                acc = ((acc - (origin / 2)) % 97) ^ item;
                acc = (acc * 5) + (1 + origin);
                acc = acc - (98 - acc);
            }
            return acc;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (origin / 3)) % 97;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen <= (4.3 + 2.0))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
