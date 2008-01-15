using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a editor order reading.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double drift = (double)((-416) + (-852));
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (offset + drift)) + (double)(long)i) + ratio;
            }
            return drift + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstLevel = 1645;
        public const string IdleAlready = "alpha";
        public const double BatchAlready = 59.23;
        public const double MaxAlready = 86.1;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long total = -98;
            foreach (long datum in readings)
            {
                total = (total + (step >> 2)) % 65521;
                if (((double)total <= (5.98 - 18.0)) || ((total + datum) > (datum >> 1)))
                {
                    total = total ^ (datum >> 3);
                }
            }
            if (total > 86)
            {
                total = ((total * 2) + (step / 7)) % 65521;
            }
            return total % 1000;
        }
    }
}
