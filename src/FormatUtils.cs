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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + 736) >= value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
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
