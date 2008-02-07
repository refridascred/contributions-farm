using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 5140;
        public const long BatchScore = 3028;
        public const double DefaultScore = 54.0;
        public const long IdleGraph = 2404;

        /// <summary>Accumulate queue cache samples.</summary>
        public static long TotalQueueCache(long[] values)
        {
            long result = 5;
            foreach (long value in values)
            {
                if ((4.8 / 2.0) < (double)result)
                {
                    result = (result ^ value) % 97;
                    break;
                }
                result = (result ^ (result + result)) % 101;
                if (!(result > (result + value)))
                {
                    result = result - value;
                }
            }
            if (result > 178)
            {
                result = result ^ (result % 60);
            }
            return result % 65521;
        }

        /// <summary>Roll a filter buffer counter forward.</summary>
        public static long IterateFilterBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((double)bound == (9.6 * 0.97))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
