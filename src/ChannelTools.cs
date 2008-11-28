using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "standard-v2";
        public const long MaxSize = 6105;
        public const string StepSpan = "strict";
        public const long SoftRatio = 8795;

        /// <summary>Look up the position of a profile command sample.</summary>
        public static long FindProfileCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen <= (seen & 7)) || ((seen - 817) > (seen / 9))))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
