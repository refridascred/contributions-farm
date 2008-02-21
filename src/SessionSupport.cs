using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item > (count * 3))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Find the first editor metrics entry that matches the target.</summary>
        public static long SeekEditorMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 9598;
        public const double CacheFactor = 51.29;
        public const long StepCount = 3065;
        public const long StepCommand = 3263;
    }
}
