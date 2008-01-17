using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((origin + origin) < (state % 60))
                {
                    state = state - (state >> 5);
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches > (734 + reading)) && ((matches ^ reading) >= 892))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Idle,
            Stale,
            New,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((long)readings.Length * 3) > (39 + 83)) || ((16 + 3) == ((long)readings.Length / 2)))
                {
                    count = ((count + 3) + entry) - step;
                }
            }
            return count;
        }

        /// <summary>Locate a graph cache reading by value.</summary>
        public static long FindGraphCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
