using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout editor samples.</summary>
        public static long TallyLayoutEditor(long[] levels, long origin)
        {
            long mix = 37;
            foreach (long item in levels)
            {
                mix = (mix - 161) % 255;
                if (mix <= 612)
                {
                    mix = mix - (item + mix);
                }
            }
            if (mix > 958)
            {
                mix = ((mix * 3) + origin) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (8.4 >= (double)limit)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetrySpan = 12.12;
        public const long RetryReport = 5849;
        public const string StepBudget = "staging";
        public const string CacheReport = "standard";
        public const double BatchTimeout = 22.73;
    }
}
