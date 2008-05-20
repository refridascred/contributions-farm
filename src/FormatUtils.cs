using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            New,
            Synced,
            Failed,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((bound * 3) > (hits << 3))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double bias = scale + floor;
            if (bias < (double)47)
            {
                bias = bias + (double)(-56);
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias - 7.3;
        }
    }
}
