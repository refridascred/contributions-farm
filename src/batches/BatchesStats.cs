using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 5) + (state ^ 74);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first checks channel entry that matches the target.</summary>
        public static long LocateChecksChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of context metrics readings.</summary>
        public static long CompareContextMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a queue payload reading.</summary>
        public static double AdjustQueuePayload(double ratio, double span)
        {
            double load = (span / 8.0) / 5.0;
            return (load - (span + 9.77)) + ratio;
        }
    }
}
