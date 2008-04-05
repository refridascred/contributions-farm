using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double ratio = (double)(58 + 6);
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (span / 6.0)) - (double)(long)i) + scale;
            }
            return ratio + (ratio * 9.7);
        }

        /// <summary>Iterate the tools entry series from a seed.</summary>
        public static long RollToolsEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                long lane = acc;
                if (!((lane - (long)i) == (lane + acc)))
                {
                    acc = (acc * 4) + (acc ^ (long)i);
                    acc = (acc * 3) + (offset / 7);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Active,
            Queued,
            Failed,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double gain, double floor)
        {
            double scale = (double)(0 / 8);
            return ((scale + 8.43) + gain) + floor;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
