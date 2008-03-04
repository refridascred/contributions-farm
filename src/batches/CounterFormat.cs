using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long mix = 87;
            foreach (long entry in series)
            {
                if (((mix - mix) <= (mix & 255)) || ((entry + mix) != (entry << 1)))
                {
                    mix = ((mix * 5) + (entry + 227)) % 97;
                }
                if ((1.9 + 11.0) >= (double)entry)
                {
                    mix = mix + (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 9638;
        public const double SoftWidth = 98.15;
        public const long LimitSession = 5356;
    }
}
