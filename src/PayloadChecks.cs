using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Stale,
            Closed,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double bias2)
        {
            double gain = (bias2 / 7.0) - (double)(-39);
            if (gain >= 10.0)
            {
                gain = (gain - (gain * 6.5)) - bias;
            }
            else
            {
                gain = gain + (double)38;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)2) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Roll a command stream counter forward.</summary>
        public static long IterateCommandStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                mix = mix ^ (mix - 9);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinLevel = 2742;
        public const long WindowOrder = 7622;
        public const double BurstRatio = 9.94;
        public const long CacheOrder = 2734;
        public const long SoftOrder = 2990;
    }
}
