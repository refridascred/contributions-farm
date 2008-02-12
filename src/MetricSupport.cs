using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate channel payload samples.</summary>
        public static long DigestChannelPayload(long[] readings)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                mark = (mark + (sample ^ sample)) % 97;
            }
            if (mark > (-14))
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Digest a series of counter notes entries.</summary>
        public static long TallyCounterNotes(long[] samples)
        {
            long total = -7;
            foreach (long reading in samples)
            {
                if (89 > (reading << 2))
                {
                    total = ((total << 2) ^ (total % 7)) % 65521;
                }
            }
            if (total < 4)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double offset)
        {
            double load = (double)((-64) >> 4);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + scale) + (double)(long)i) + offset;
            }
            return load + (scale + scale);
        }
    }
}
