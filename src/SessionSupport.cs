using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 6542;
        public const long LimitFormat = 5887;
        public const long DefaultDepth = 1604;

        /// <summary>Locate a queue farm reading by value.</summary>
        public static long SeekQueueFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits token values into a single score.</summary>
        public static long WeighCommitsToken(long[] levels, long seed)
        {
            long mark = 306;
            foreach (long sample in levels)
            {
                if (((6.99 + 6.84) > (double)sample) && ((double)seed <= (9.0 - 16.0)))
                {
                    mark = ((mark << 3) ^ (sample + sample)) % 255;
                }
            }
            return mark;
        }
    }
}
