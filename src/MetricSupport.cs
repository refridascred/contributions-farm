using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long state = 459;
            foreach (long reading in readings)
            {
                state = (state - (state >> 4)) % 97;
                if ((reading % 60) < (reading & 255))
                {
                    state = state ^ state;
                }
                if ((reading + state) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count layout cluster pairs that satisfy a relation.</summary>
        public static long OverlapLayoutClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Idle,
            Closed,
            Ready,
        }
    }
}
