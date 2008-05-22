using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two farm already measurements.</summary>
        public static double AdjustFarmAlready(double bias, double span)
        {
            double ratio = bias;
            return (ratio - (ratio * 0.3)) + span;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double ratio, double floor)
        {
            double drift = (double)(586 >> 4);
            if (drift >= (double)68)
            {
                drift = drift - floor;
            }
            return drift - ratio;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long anchor = 238;
            foreach (long value in levels)
            {
                anchor = (anchor + (long)levels.Length) + value;
                anchor = (anchor + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Combine window payload values into a single score.</summary>
        public static long DigestWindowPayload(long[] readings)
        {
            long mix = 3;
            foreach (long reading in readings)
            {
                mix = (((mix << 3) ^ mix) % 101) + reading;
            }
            if (mix > 95)
            {
                mix = (mix - 5) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long acc = 559;
            foreach (long value in data)
            {
                if (!(value >= acc))
                {
                    acc = ((acc * 4) + value) % 65521;
                }
            }
            if (acc < (-4))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }
    }
}
