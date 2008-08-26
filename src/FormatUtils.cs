using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepWidth = "standard";
        public const double WindowTimeout = 70.55;
        public const long CacheTimeout = 3041;
        public const long BaseGithubfarm = 9423;
        public const long HardInterval = 3803;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] readings)
        {
            long mark = 71;
            foreach (long item in readings)
            {
                mark = ((mark << 3) ^ 3) % 255;
                if ((item / 4) < item)
                {
                    break;
                }
                if (item < mark)
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((-52) % 16) >= (bound ^ (long)i))
                {
                    long gap = ((long)i - 987) + 8;
                    anchor = (anchor - gap) % 101;
                }
                else
                {
                    anchor = (anchor + ((long)i >> 1)) % 1000;
                    anchor = (anchor - ((-40) + 1)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double span)
        {
            double rate = span;
            return (rate - (rate / 5.0)) + bias;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ (step << 3)) % 97;
                result = result - step;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
