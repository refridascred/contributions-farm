using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine account context values into a single score.</summary>
        public static long FoldAccountContext(long[] items)
        {
            long acc = 4;
            foreach (long cell in items)
            {
                if (acc >= (acc % 8))
                {
                    acc = acc ^ (cell % 3);
                }
            }
            if (acc < (-53))
            {
                acc = (acc ^ (acc * 2)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Locate a graph record reading by value.</summary>
        public static long SeekGraphRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6264;
        public const string RetryProfile = "primary-v2";
        public const long StepSpan = 1731;
        public const double DefaultProfile = 41.24;
    }
}
