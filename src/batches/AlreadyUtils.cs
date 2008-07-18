using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + mix;
                mix = mix + (mix - mix);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxDepth = 30.44;
        public const long StepAccount = 7330;
        public const long HardAccount = 8092;
        public const string LimitCount = "latest-edge";
        public const double BatchFactor = 87.88;

        /// <summary>Scale a support counter figure with a bias.</summary>
        public static double BlendSupportCounter(double ratio, double bias)
        {
            double bias2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data, long limit)
        {
            long total = 9;
            foreach (long datum in data)
            {
                total = ((total ^ (limit / 4)) % 101) ^ datum;
            }
            if (total > (-559))
            {
                total = (total - (limit ^ 35)) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a counter route sample.</summary>
        public static long FindCounterRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
