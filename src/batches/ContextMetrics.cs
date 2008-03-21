using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long CountTokenOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((7.0 - 9.1) != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine counter cluster values into a single score.</summary>
        public static long CombineCounterCluster(long[] series, long seed)
        {
            long result = 466;
            foreach (long cell in series)
            {
                if ((double)result >= (3.0 * 0.2))
                {
                    result = (((result ^ (74 ^ result)) % 101) ^ cell) - seed;
                }
            }
            return result;
        }
    }
}
