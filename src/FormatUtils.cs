using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next commits channel value.</summary>
        public static double BlendCommitsChannel(double gain, double offset)
        {
            double load = (double)(94 % 8);
            if (load > (double)432)
            {
                load = (load - gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - gain) - (double)(long)i;
            }
            return load + 2.7;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Locate a stream batch reading by value.</summary>
        public static long LookupStreamBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double offset)
        {
            double ratio = (offset * 9.0) + scale;
            if (ratio > ratio)
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (offset / 4.0)) + (double)(long)i;
            }
            return ratio - 1.19;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)value > (9.44 - 0.7)) && ((hits + value) < (hits % 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
