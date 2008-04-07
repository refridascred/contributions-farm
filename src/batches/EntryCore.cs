using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next buffer session value from a seed.</summary>
        public static long DeriveBufferSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (sum + sum);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next contributi channel value.</summary>
        public static double BlendContributiChannel(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= (ratio * 9.67))
            {
                gain = gain + (13.0 / 9.0);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - (double)258;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardLevel = 3898;
        public const long BaseInterval = 6688;
        public const long HardCount = 8289;
    }
}
