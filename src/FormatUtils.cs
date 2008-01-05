using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double ratio, double bias)
        {
            double load = ratio;
            if (load >= bias)
            {
                load = load + (double)8;
            }
            else
            {
                load = load - (ratio / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (double)62;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Done,
            Idle,
            Draft,
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long TallyGraphMetric(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((mix & 1) != (sample - mix))
                {
                    mix = ((mix << 3) ^ ((-86) + 382)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double bias = floor / 2.0;
            if (bias <= (scale - 8.0))
            {
                bias = bias - (8.9 - 7.3);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - (9.0 / 3.0);
        }
    }
}
