using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of profile farm readings.</summary>
        public static long CompareProfileFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 1397;
        public const long BatchSpan = 3832;
        public const long IdleChannel = 8473;
        public const long MinChannel = 9234;
        public const long BaseChannel = 8775;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long step)
        {
            if (bound > 227)
            {
                return 7;
            }
            else
            {
                if ((9.0 + 0.2) >= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (!((1.69 - 1.11) < (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
