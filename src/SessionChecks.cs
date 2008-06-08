using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of window route entries.</summary>
        public static long DigestWindowRoute(long[] levels)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                mix = mix ^ (reading & 1);
            }
            return mix % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "local-edge";
        public const double HardMetrics = 37.81;
        public const long LimitCount = 4953;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings)
        {
            long mark = -9;
            foreach (long entry in readings)
            {
                if ((entry > (entry - entry)) || ((mark ^ mark) <= mark))
                {
                    mark = ((mark << 3) ^ (mark / 7)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double drift = gain + 8.8;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (floor + floor);
        }
    }
}
