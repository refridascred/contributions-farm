using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Match up already stats samples.</summary>
        public static long OverlapAlreadyStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a entry queue reading.</summary>
        public static double AdjustEntryQueue(double ratio, double floor)
        {
            double weight = ratio;
            if (weight > (15.0 / 3.0))
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (ratio + weight);
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + value) >= (value & 255)) || ((5.3 <= (double)value) || ((value ^ origin) >= value)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
