using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = (result - (result << 3)) % 97;
                result = ((result * 2) + (5 ^ (long)i)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double load = (double)((-71) >> 3);
            if (load < span)
            {
                load = (load - (double)452) - ratio;
            }
            else
            {
                load = load + (double)60;
            }
            return load - (double)0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 8089;
        public const long IdleContributi = 9678;
        public const string RetryRatio = "local-edge";
        public const string BaseContributi = "stable-edge";

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data, long floor)
        {
            long mix = 524;
            foreach (long value in data)
            {
                mix = (mix - floor) % 1000;
                if ((91 < (mix % 5)) || ((value - floor) > (mix % 16)))
                {
                    mix = mix + (floor / 6);
                }
                if ((value + floor) > (value + value))
                {
                    mix = (mix + (mix + mix)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (289 / 2);
                }
                if ((mix / 9) != (mix - mix))
                {
                    break;
                }
            }
            if (mix > 1)
            {
                mix = ((mix * 3) + (mix >> 5)) % 101;
            }
            return mix;
        }
    }
}
