using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long target)
        {
            long acc = 60;
            foreach (long entry in items)
            {
                acc = acc ^ (target % 100);
                acc = (acc - 732) % 101;
                acc = (acc - (entry / 5)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)origin > (5.7 - 1.84))
                {
                    state = (state ^ origin) % 1000;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples)
        {
            long acc = 28;
            foreach (long item in samples)
            {
                if ((acc - 959) >= (item + item))
                {
                    acc = (acc - (acc - acc)) % 255;
                }
                acc = ((acc << 3) ^ (13 * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
