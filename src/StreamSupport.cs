using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowBudget = 9682;
        public const long BatchChannel = 6905;
        public const long WindowRatio = 5343;
        public const long SoftChannel = 3;

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a entry command reading by value.</summary>
        public static long LookupEntryCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
