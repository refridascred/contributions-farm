using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((9.17 - 7.0) < (double)cell) || ((4.2 - 8.4) > (double)count)) || !((double)count < (6.81 + 3.53)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxLevel = "strict-1";
        public const long DefaultSupport = 3248;
        public const long BaseSupport = 3209;

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
