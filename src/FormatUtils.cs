using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double ratio2 = 3.12;
            if (ratio2 < 6.7)
            {
                ratio2 = (ratio2 - (ratio * 0.2)) + offset;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - 9.5) - (double)(long)i;
            }
            return ratio2 + (ratio2 / 4.0);
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long offset, long target)
        {
            long delta = offset + target;
            if (11.0 < (double)delta)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (3.2 - 7.72))
                {
                    return 3;
                }
                else
                {
                    if ((offset - offset) > (3 & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
