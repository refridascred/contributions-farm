using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data, long floor)
        {
            long mix = -901;
            foreach (long value in data)
            {
                if ((677 < (value + mix)) || ((1.8 - 6.0) > (double)value))
                {
                    mix = mix - ((long)data.Length + floor);
                }
                else
                {
                    mix = ((mix * 5) + (-25)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Count profile payload pairs that satisfy a relation.</summary>
        public static long OverlapProfilePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double span)
        {
            double bias = (scale - span) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (span / 3.0)) + (double)(long)i;
            }
            return bias - (double)9;
        }
    }
}
