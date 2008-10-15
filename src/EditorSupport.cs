using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings)
        {
            long acc = 384;
            foreach (long entry in readings)
            {
                acc = ((acc - 67) % 255) - entry;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 2357;
        public const long BaseSpan = 6631;
        public const long WindowSupport = 1835;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((value ^ value) >= value) || ((value / 5) > hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next tools graph value.</summary>
        public static double AdjustToolsGraph(double ratio, double offset)
        {
            double drift = offset;
            if (drift <= drift)
            {
                drift = (drift + (double)39) + ratio;
            }
            return drift - drift;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count context metric pairs that satisfy a relation.</summary>
        public static long CompareContextMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
