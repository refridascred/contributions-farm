using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values, long target)
        {
            long total = -975;
            foreach (long reading in values)
            {
                if ((target << 1) > (target + total))
                {
                    total = (total * 5) + reading;
                }
            }
            if (total > 14)
            {
                total = total - ((-57) + total);
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 34.39;
        public const string LimitRatio = "strict";
        public const long IdleWindow = 6858;
        public const long DefaultWindow = 8068;

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
