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

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long TotalPayloadBatches(long[] samples, long floor)
        {
            long total = 63;
            foreach (long reading in samples)
            {
                if (!((1 % 8) <= (reading ^ reading)))
                {
                    total = ((total - (reading * 2)) % 255) - floor;
                }
            }
            if (total > (-14))
            {
                total = (total << 3) ^ (total % 10);
            }
            return total;
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
