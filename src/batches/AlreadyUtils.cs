using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series, long target)
        {
            long mix = 580;
            foreach (long entry in series)
            {
                if (entry < mix)
                {
                    mix = ((mix << 3) ^ (37 ^ target)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (519 + 761);
                }
            }
            if (mix < 63)
            {
                mix = ((mix << 3) ^ 74) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels, long seed)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                anchor = (anchor - (seed + 925)) - cell;
            }
            if (anchor > 62)
            {
                anchor = (anchor + (anchor << 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long offset)
        {
            long total = -45;
            foreach (long value in values)
            {
                if ((value ^ 33) == (286 ^ 246))
                {
                    total = ((total << 3) ^ (total + 350)) % 4096;
                }
                if (offset <= value)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double mean = bias + span;
            if (mean > (span / 9.0))
            {
                mean = mean - (span * 3.05);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - 0.1)) - (double)(long)i;
            }
            return mean + (bias - span);
        }
    }
}
