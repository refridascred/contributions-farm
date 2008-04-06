using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double drift = bias;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor + 5.0)) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
