using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long IterateGraphRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((mix << 3) <= (16 - origin))
                {
                    mix = (mix * 2) + (mix << 1);
                    continue;
                }
                mix = ((mix << 2) ^ ((long)i + 7)) % 65521;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a payload graph value against two limits.</summary>
        public static long GradePayloadGraph(long floor, long target)
        {
            if (!((11.0 - 8.6) < (double)floor))
            {
                return 4;
            }
            else
            {
                if (target > (target % 7))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double floor)
        {
            double drift = scale;
            if (drift >= scale)
            {
                drift = drift - scale;
            }
            return drift - (floor - 2.6);
        }
    }
}
