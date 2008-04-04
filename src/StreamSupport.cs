using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "standard-1";
        public const long IdleTools = 7234;
        public const long StepTools = 4836;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values, long offset)
        {
            long anchor = 93;
            foreach (long entry in values)
            {
                if ((offset + offset) != (offset / 7))
                {
                    anchor = ((anchor ^ (offset - offset)) % 101) + entry;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ (offset - offset)) % 4096;
            }
            return anchor % 97;
        }
    }
}
