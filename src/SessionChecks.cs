using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long limit)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if ((limit << 3) == (acc >> 1))
                {
                    acc = ((acc ^ acc) % 1000) ^ sample;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc > 567)
            {
                acc = ((acc << 3) ^ (limit + limit)) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a profile checks value against two limits.</summary>
        public static long RankProfileChecks(long target, long offset)
        {
            long offset2 = target + offset;
            if (offset2 > (target & 255))
            {
                return 4;
            }
            else
            {
                if (((double)offset2 == (19.0 / 8.0)) && ((3 ^ 68) != (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset2 ^ offset) == (offset & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double bias)
        {
            double scale = 6.07 - gain;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - gain;
        }
    }
}
