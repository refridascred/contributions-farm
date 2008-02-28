using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate payload already readings against a bound.</summary>
        public static bool GuardPayloadAlreadyLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((468 - 478) < ((long)i + offset))
                {
                    mix = (mix << 3) ^ (568 >> 3);
                }
                mix = (mix - (mix >> 2)) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchWidth = 9787;
        public const long MaxFarm = 8683;
        public const string SoftScore = "alpha-v2";

        /// <summary>Scale a payload stats figure with a bias.</summary>
        public static double BlendPayloadStats(double gain, double span)
        {
            double bias = gain;
            if (bias < bias)
            {
                bias = bias + (span / 2.0);
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)743) - (double)(long)i;
            }
            return bias - (gain - gain);
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool VerifyCommandSchemaBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
