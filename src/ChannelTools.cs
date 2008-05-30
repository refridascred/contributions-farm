using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryRatio = 82.52;
        public const long IdleCounter = 9028;
        public const double WindowTimeout = 76.65;

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!((8 + limit) >= (limit + (-40))))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
