using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                long tally = mix;
                if ((tally & 1) <= tally)
                {
                    mix = ((mix * 2) + (target << 3)) % 65521;
                }
                if (!((double)mix > (8.8 + 0.3)))
                {
                    mix = mix - ((long)i & 31);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultDepth = 651;
        public const long DefaultTimeout = 9778;
        public const string MaxOrder = "legacy";
        public const long WindowOrder = 9099;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
