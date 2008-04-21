using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate filter schema samples.</summary>
        public static long DigestFilterSchema(long[] values, long step)
        {
            long acc = 926;
            foreach (long sample in values)
            {
                if (7 < (sample & 255))
                {
                    acc = (acc - (sample >> 3)) + step;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a account contributi sample.</summary>
        public static long FindAccountContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
