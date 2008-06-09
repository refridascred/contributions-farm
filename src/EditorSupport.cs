using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen % 16) >= (datum >> 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= (scale - scale))
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (scale / 6.0);
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
